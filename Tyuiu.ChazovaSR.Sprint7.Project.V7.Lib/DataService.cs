﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Tyuiu.ChazovaSR.Sprint7.Project.V7.Lib
{
    public class DataService
    {
        public string[,] GetMatrix(string path) // возврашает данные из excel
        {
            string[] str = File.ReadAllLines(path);

            int columns = str[0].Split(';').Length;
            int rows = str.Length;

            string[,] matrix = new string[rows, columns];

            for (int i = 0; i < str.Length; i++)
            {
                string strIndexI = str[i];
                string[] strArr = strIndexI.Split(';');
                for (int c = 0; c < strArr.Length; c++)
                {
                    matrix[i, c] = strArr[c];
                }
            }
            return matrix;
        }


        public string[] ArrayStrEntrance(string[,] DataTable)
        {
            int flag = 0;
            string strCountEntrance = "";
            for (int i = 1; i < DataTable.GetLength(0); i++)
            {
                flag = 0;
                for (int a = 1; a < i; a++)
                {
                    if (Convert.ToInt32(DataTable[a, 0]) == Convert.ToInt32(DataTable[i, 0]))
                        flag = 1;
                }
                if (flag == 0)
                    strCountEntrance += Convert.ToString(DataTable[i, 0]) + " ";
            }
            string[] str = strCountEntrance.Split(' ');
            string[] res = new string[str.Length - 1];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = str[i];
            }


            return res;
        }


        public int[] ArraySumFlatsInEntrance(object[,] DataTable, string[] Entrance)
        {
            int[] res = new int[Entrance.Length];
            for (int i = 0; i < Entrance.Length; i++)
            {
                for (int j = 1; j < DataTable.GetLength(0); j++)
                {
                    if (Convert.ToInt32(Entrance[i]) == Convert.ToInt32(DataTable[j, 0]))
                        res[i] += 1;
                }
            }
            return res;
        }

        public int[] ArrayCountOwnOrRent(object[,] DataTable) // собственники или арендаторы
        {
            int[] res = new int[2];
            for (int i = 1; i < DataTable.GetLength(0); i++)
            {
                if (Convert.ToString(DataTable[i, 3]) != "собственник")
                    res[0] += 1; // арендаторы
                else
                    res[1] += 1;
            }
            return res;
        }


        public string[,] SortMin(string[,] matrix, int NumberColumn)
        {
            int[] Entrance = new int[matrix.GetLength(0) - 1];
            Entrance[Entrance.Length - 1] = Convert.ToInt32(matrix[matrix.GetLength(0) - 1, NumberColumn]);
            for (int i = 0; i < Entrance.Length - 1; i++)
            {
                Entrance[i] = Convert.ToInt32(matrix[i + 1, NumberColumn]);
            }

            Array.Sort(Entrance, (x, y) => x.CompareTo(y));

            string[,] SortMatrix = new string[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < SortMatrix.GetLength(1); i++)
            {
                SortMatrix[0, i] = matrix[0, i];
            }

            for (int i = 0; i < SortMatrix.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < matrix.GetLength(0); j++)
                {
                    if (Entrance[i] == Convert.ToInt32(matrix[j, NumberColumn]))
                    {
                        for (int c = 0; c < SortMatrix.GetLength(1); c++)
                        {
                            SortMatrix[i + 1, c] = matrix[j, c];
                        }
                        matrix[j, NumberColumn] = "-1";
                        break;
                    }
                }
            }
            return SortMatrix;
        }



        public string[,] SortMax(string[,] matrix, int NumberColumn)
        {
            int[] Entrance = new int[matrix.GetLength(0) - 1];
            Entrance[Entrance.Length - 1] = Convert.ToInt32(matrix[matrix.GetLength(0) - 1, NumberColumn]);
            for (int i = 0; i < Entrance.Length - 1; i++)
            {
                Entrance[i] = Convert.ToInt32(matrix[i + 1, NumberColumn]);
            }

            Array.Sort(Entrance, (x, y) => y.CompareTo(x));

            string[,] SortMatrix = new string[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < SortMatrix.GetLength(1); i++)
            {
                SortMatrix[0, i] = matrix[0, i];
            }

            for (int i = 0; i < SortMatrix.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < matrix.GetLength(0); j++)
                {
                    if (Entrance[i] == Convert.ToInt32(matrix[j, NumberColumn]))
                    {
                        for (int c = 0; c < SortMatrix.GetLength(1); c++)
                        {
                            SortMatrix[i + 1, c] = matrix[j, c];
                        }
                        matrix[j, NumberColumn] = "-1";
                        break;
                    }
                }
            }
            return SortMatrix;
        }


        public string[,] SortMinOwnOrRent(string[,] matrix, int NumberColumn)
        {
            string[,] SortMatrix = new string[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < SortMatrix.GetLength(1); i++)
            {
                SortMatrix[0, i] = matrix[0, i];
            }

            int count = 0;
            for (int i = 0; i < SortMatrix.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < matrix.GetLength(0); j++)
                {
                    if (("собственник" == matrix[j, NumberColumn]) && (matrix[j, NumberColumn] != "-1"))
                    {
                        for (int c = 0; c < SortMatrix.GetLength(1); c++)
                        {
                            SortMatrix[i + 1, c] = matrix[j, c];
                        }
                        matrix[j, NumberColumn] = "-1";
                        count++;
                        break;
                    }
                }
            }

            for (int i = count; i < SortMatrix.GetLength(0); i++)
            {
                for (int j = 1; j < matrix.GetLength(0); j++)
                {
                    if (matrix[j, NumberColumn] != "-1")
                    {
                        for (int c = 0; c < SortMatrix.GetLength(1); c++)
                        {
                            SortMatrix[i + 1, c] = matrix[j, c];
                        }
                        matrix[j, NumberColumn] = "-1";
                        break;
                    }
                }
            }
            return SortMatrix;
        }

        public string[,] SortMaxOwnOrRent(string[,] matrix, int NumberColumn)
        {
            string[,] SortMatrix = new string[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < SortMatrix.GetLength(1); i++)
            {
                SortMatrix[0, i] = matrix[0, i];
            }

            int count = 0;
            for (int i = 0; i < SortMatrix.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < matrix.GetLength(0); j++)
                {
                    if ((matrix[j, NumberColumn] != "собственник") && (matrix[j, NumberColumn] != "-1"))
                    {
                        for (int c = 0; c < SortMatrix.GetLength(1); c++)
                        {
                            SortMatrix[i + 1, c] = matrix[j, c];
                        }
                        matrix[j, NumberColumn] = "-1";
                        count++;
                        break;
                    }
                }
            }

            for (int i = count; i < SortMatrix.GetLength(0); i++)
            {
                for (int j = 1; j < matrix.GetLength(0); j++)
                {
                    if (matrix[j, NumberColumn] != "-1")
                    {
                        for (int c = 0; c < SortMatrix.GetLength(1); c++)
                        {
                            SortMatrix[i + 1, c] = matrix[j, c];
                        }
                        matrix[j, NumberColumn] = "-1";
                        break;
                    }
                }
            }
            return SortMatrix;
        }



        public string[] Search(string[,] DataTable, string FIO)
        {
            string[] res = new string[7];
            for (int i = 0; i < DataTable.GetLength(0); i++)
            {
                if (DataTable[i, 2] == FIO)
                {
                    for (int j = 0; j < res.Length; j++)
                    {
                        res[j] = DataTable[i, j];
                    }
                }
            }
            return res;
        }

        public bool FlatExist(string path, int Entrance, int Flat)
        {
            string[] strLines = File.ReadAllLines(path);
            bool res = false;
            for (int i = 1; i < strLines.Length; i++)
            {
                string[] strElment = strLines[i].Split(';');
                for (int j = 0; j < strElment.Length; j++)
                {
                    if ((Entrance == Convert.ToInt32(strElment[0])) && (Flat == Convert.ToInt32(strElment[1])))
                        res = true;
                }
            }
            return res;
        }
    }
}
