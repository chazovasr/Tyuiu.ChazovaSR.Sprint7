using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.ChazovaSR.Sprint7.Project.V7.Lib;

namespace Tyuiu.ChazovaSR.Sprint7.Project.V7
{
    public partial class FormAddOrDelete : Form
    {
        DataService ds = new DataService();
        public static string path = @"C:\Users\chazo\source\repos\Tyuiu.ChazovaSR.Sprint7\Жильцы.csv";

        public FormAddOrDelete()
        {
            InitializeComponent();
            dataGridViewInfo_CSR.RowCount = 100;
            dataGridViewInfo_CSR.ColumnCount = 100;
            for (int i = 0; i < 100; i++)
            {
                dataGridViewInfo_CSR.Columns[i].Width = 200;
            }
            string[,] DataTable = ds.GetMatrix(path);
            for (int i = 0; i < DataTable.GetLength(0); i++)
            {
                for (int j = 0; j < DataTable.GetLength(1); j++)
                {
                    dataGridViewInfo_CSR.Rows[i].Cells[j].Value = DataTable[i, j];
                }
            }
        }

        private void buttonSaveFile_CSR_Click(object sender, EventArgs e)
        {
            if ((textBoxFIO_CSR.Text == "") || (textBoxAddEntrance_CSR.Text == "") || (textBoxAddFlat_CSR.Text == "") || ((textBoxOwnOrRent_CSR.Text == "") && (radioButtonRent_CSR.Checked == true)) || (textBoxForRent_CSR.Text == ""))
                MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string str = "";

                bool FlatBusy = ds.FlatExist(path, Convert.ToInt32(textBoxAddEntrance_CSR.Text), Convert.ToInt32(textBoxAddFlat_CSR.Text));

                if (FlatBusy)
                    MessageBox.Show("Данная квартира занята", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    for (int i = 0; i < 7; i++)
                    {
                        if (radioButtonRent_CSR.Checked == true)
                        {
                            str = $"{textBoxAddEntrance_CSR.Text};{textBoxAddFlat_CSR.Text};{textBoxFIO_CSR.Text};{textBoxOwnOrRent_CSR.Text};{textBoxForRent_CSR.Text}";
                        }
                        else
                        {
                            str = $"{textBoxAddEntrance_CSR.Text};{textBoxAddFlat_CSR.Text};{textBoxFIO_CSR.Text};собственник;{textBoxForRent_CSR.Text}";
                        }
                    }
                    File.AppendAllText(path, str + "\n");


                    textBoxFIO_CSR.Text = "";
                    textBoxAddEntrance_CSR.Text = "";
                    textBoxAddFlat_CSR.Text = "";
                    textBoxOwnOrRent_CSR.Text = "";
                    textBoxForRent_CSR.Text = "";
                    radioButtonOwn_CSR.Checked = false;
                    radioButtonRent_CSR.Checked = false;

                    ////////
                    string[,] DataMatrix = ds.GetMatrix(path); // данные из excel

                    int rows = DataMatrix.GetLength(0);
                    int columns = DataMatrix.GetLength(1);

                    for (int r = 0; r <= rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            dataGridViewInfo_CSR.Rows[r].Cells[c].Value = "";
                        }
                    }

                    for (int r = 0; r < rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            dataGridViewInfo_CSR.Rows[r].Cells[c].Value = DataMatrix[r, c];
                        }
                    }
                    /////////

                    MessageBox.Show("Новый житель зарегистрирован!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void radioButtonOwn_CSR_CheckedChanged(object sender, EventArgs e)
        {
            textBoxOwnOrRent_CSR.Text = "";
            textBoxOwnOrRent_CSR.Enabled = false;
            textBoxOwnOrRent_CSR.Text = "собственник";
        }

        private void radioButtonRent_CSR_CheckedChanged(object sender, EventArgs e)
        {
            textBoxOwnOrRent_CSR.Text = "";
            textBoxOwnOrRent_CSR.Enabled = true;
        }

        private void buttonDelete_CSR_Click(object sender, EventArgs e)
        {
            if ((textBoxDeleteEntrance_CSR.Text == "") || (textBoxDeleteFlat_CSR.Text == ""))
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool FlatBusy = ds.FlatExist(path, Convert.ToInt32(textBoxDeleteEntrance_CSR.Text), Convert.ToInt32(textBoxDeleteFlat_CSR.Text));

                if (FlatBusy == false)
                    MessageBox.Show("Такой квартиры нет в базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    string[] strRows = File.ReadAllLines(path);

                    for (int i = 0; i < strRows.Length; i++)
                    {
                        string[] strIndex = strRows[i].Split(';');
                        if ((strIndex[0] == textBoxDeleteEntrance_CSR.Text) && (strIndex[1] == textBoxDeleteFlat_CSR.Text))
                            strRows[i] = "";
                    }
                    strRows = strRows.Where(i => i != "").ToArray();

                    File.Delete("Жильцы.csv");

                    saveFileDialogInfoFlat_CSR.FileName = "Жильцы.csv";
                    saveFileDialogInfoFlat_CSR.ShowDialog();

                    path = saveFileDialogInfoFlat_CSR.FileName;

                    File.WriteAllLines(path, strRows, Encoding.UTF8);

                    string[,] DataMatrix = ds.GetMatrix(path); // данные из excel

                    int rows = DataMatrix.GetLength(0);
                    int columns = DataMatrix.GetLength(1);

                    for (int r = 0; r <= rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            dataGridViewInfo_CSR.Rows[r].Cells[c].Value = "";
                        }
                    }

                    for (int r = 0; r < rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            dataGridViewInfo_CSR.Rows[r].Cells[c].Value = DataMatrix[r, c];
                        }
                    }
                    MessageBox.Show("Квартира удалена!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            textBoxDeleteFlat_CSR.Text = "";
            textBoxDeleteEntrance_CSR.Text = "";
        }
    }    
}
