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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            dataGridViewInfoPeople_CSR.RowCount = 100;
            dataGridViewInfoPeople_CSR.ColumnCount = 100;
            for (int i = 0; i < 100; i++)
            {
                dataGridViewInfoPeople_CSR.Columns[i].Width = 200;
            }
        }
        public static string path = @"C:\Users\chazo\source\repos\Tyuiu.ChazovaSR.Sprint7\Жильцы.csv";
        DataService ds = new DataService();
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        



        private void buttonMinEntrance_CSR_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMin(DataMatrix, 0);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    dataGridViewInfoPeople_CSR.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
        }

        private void buttonMaxEntrance_CSR_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMaxDataMatrix = ds.SortMax(DataMatrix, 0);

            for (int r = 0; r < SortMaxDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMaxDataMatrix.GetLength(1); c++)
                {
                    dataGridViewInfoPeople_CSR.Rows[r].Cells[c].Value = SortMaxDataMatrix[r, c];
                }
            }
        }

        private void buttonBeginOwn_CSR_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMinOwnOrRent(DataMatrix, 3);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    dataGridViewInfoPeople_CSR.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
        }

        private void buttonbBeginRent_CSR_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMaxDataMatrix = ds.SortMaxOwnOrRent(DataMatrix, 3);

            for (int r = 0; r < SortMaxDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMaxDataMatrix.GetLength(1); c++)
                {
                    dataGridViewInfoPeople_CSR.Rows[r].Cells[c].Value = SortMaxDataMatrix[r, c];
                }
            }
        }

        private void buttonFlatChart_CSR_Click(object sender, EventArgs e)
        {
            chartInfo_CSR.Series[0].Points.Clear();

            this.chartInfo_CSR.ChartAreas[0].AxisX.Title = "Номер подъезда";
            this.chartInfo_CSR.ChartAreas[0].AxisY.Title = "Количество занятых квартир";

            string[,] DataTable = ds.GetMatrix(path); // матрица данных из файла

            string[] strEntrance = ds.ArrayStrEntrance(DataTable); // номера подъездов

            int[] arraySumPeopleInEntrance = ds.ArraySumFlatsInEntrance(DataTable, strEntrance); // массив количества занятых квартир в каждом подъезде

            for (int i = 0; i < strEntrance.Length; i++)
            {
                chartInfo_CSR.Series[0].Points.AddXY(strEntrance[i], arraySumPeopleInEntrance[i]);
            }
        }

        private void buttonOwnOrRent_CSR_Click(object sender, EventArgs e)
        {
            chartInfo_CSR.Series[0].Points.Clear();

            this.chartInfo_CSR.ChartAreas[0].AxisX.Title = "";
            this.chartInfo_CSR.ChartAreas[0].AxisY.Title = "Количество квартир";

            string[,] DataTable = ds.GetMatrix(path);

            int[] ArrayCountBuyOrRent = ds.ArrayCountOwnOrRent(DataTable); // массив кол-во аренды квартиры и кол-во покупки квартиры

            string[] strRentOrBuy = { "арендаторы", "Собственники" };

            for (int i = 0; i < strRentOrBuy.Length; i++)
            {
                chartInfo_CSR.Series[0].Points.AddXY(strRentOrBuy[i], ArrayCountBuyOrRent[i]);
            }
        }

        private void buttonGetDataTable_CSR_Click(object sender, EventArgs e)
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
            buttonbBeginRent_CSR.Enabled = true;
            buttonBeginOwn_CSR.Enabled = true;
            buttonMaxEntrance_CSR.Enabled = true;
            buttonMinEntrance_CSR.Enabled = true;
        }

        private void ToolStripMenuItemDebt_CSR_Click(object sender, EventArgs e)
        {
            FormDebt formDebt = new FormDebt();
            formDebt.Show();
        }

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

        private void ToolStripMenuItemChange_CSR_Click(object sender, EventArgs e)
        {
            FormAddOrDelete formAD = new FormAddOrDelete();
            formAD.Show();
        }

        private void ToolStripMenuItemGuide_CSR_Click(object sender, EventArgs e)
        {
            FormGuide formguide = new FormGuide();
            formguide.Show();
        }

        private void ToolStripMenuItemAbout_CSR_Click(object sender, EventArgs e)
        {
            FormAboutMe formaboutme = new FormAboutMe();
            formaboutme.Show();
        }
    }
}
