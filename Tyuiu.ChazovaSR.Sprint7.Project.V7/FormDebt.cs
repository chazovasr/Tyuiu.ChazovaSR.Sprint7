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
    public partial class FormDebt : Form
    {
        public FormDebt()
        {
            InitializeComponent();
            dataGridViewInfoPeople_CSR.RowCount = 100;
            dataGridViewInfoPeople_CSR.ColumnCount = 100;
            for (int i = 0; i < 100; i++)
            {
                dataGridViewInfoPeople_CSR.Columns[i].Width = 170;
            }
        }
        public static string path = @"C:\Users\chazo\source\repos\Tyuiu.ChazovaSR.Sprint7\Задолженности.csv";
        DataService ds = new DataService();


        private void buttonBack_CSR_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path); // данные из excel

            int rows = DataMatrix.GetLength(0);
            int columns = DataMatrix.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInfoPeople_CSR.Rows[r].Cells[c].Value = DataMatrix[r, c];
                }
            }
        }

        private void buttonSearch_CSR_Click(object sender, EventArgs e)
        {
            if (textBoxFIO_CSR.Text == "")
                MessageBox.Show("Поле поиска пустое!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string[,] DataMatrix = ds.GetMatrix(path);

                string[] str = ds.Search(DataMatrix, textBoxFIO_CSR.Text);

                if (str[0] == null)
                    MessageBox.Show("Такого человека нет в базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (str[4] == "")
                    MessageBox.Show("У этого человека нет задолженностей", "Ой!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    int rows = DataMatrix.GetLength(0);
                    int columns = DataMatrix.GetLength(1);

                    for (int r = 1; r < rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            dataGridViewInfoPeople_CSR.Rows[r].Cells[c].Value = "";
                        }
                    }

                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewInfoPeople_CSR.Rows[0].Cells[c].Value = DataMatrix[0, c];
                    }

                    for (int r = 0; r < columns; r++)
                    {
                        dataGridViewInfoPeople_CSR.Rows[1].Cells[r].Value = str[r];
                    }
                    buttonBack_CSR.Enabled = true;
                }
            }
        }

        private void buttonGetDataTable_CSR_Click_1(object sender, EventArgs e)
        {
            openFileDialogGetDataTable_CSR.ShowDialog();
            string FileName = openFileDialogGetDataTable_CSR.FileName;

            string[,] DataMatrix = ds.GetMatrix(FileName); // данные из excel

            int rows = DataMatrix.GetLength(0);
            int columns = DataMatrix.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInfoPeople_CSR.Rows[r].Cells[c].Value = DataMatrix[r, c];
                }
            }
            buttonBack_CSR.Enabled = true;
        }
    }
}
