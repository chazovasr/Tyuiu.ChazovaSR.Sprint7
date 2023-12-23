using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ChazovaSR.Sprint7.Project.V7.Lib;
using System.IO;
namespace Tyuiu.ChazovaSR.Sprint7.Project.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void TestArrayStrEntrance()
        {

            string[,] DataTable =
            {
                {"ggrtgrtg","gtrgrtgtr","gtrtgr","gtrtrg","gtrrgrtg"},
                {"2","3","fewfe","собственник","пекп"},
                {"4","11","fewfe","пекп56п","пекп"},
                {"4","22","fewfe","собственник","пекп"},
                {"5","32","fewfe","пекп56п","пекп"},
            };
            string[] res = ds.ArrayStrEntrance(DataTable);
            string[] wait = { "2", "4", "5" };

            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestArraySumFlatInEntrance()
        {
            string[,] DataTable =
           {
                {"ggrtgrtg","gtrgrtgtr","gtrtgr","gtrtrg","gtrrgrtg"},
                {"2","3","fewfe","собственник","пекп"},
                {"4","11","fewfe","пекп56п","пекп"},
                {"4","22","fewfe","собственник","пекп"},
                {"5","32","fewfe","пекп56п","пекп"},
            };
            object[,] DataTableobj =
            {
                {"ggrtgrtg","gtrgrtgtr","gtrtgr","gtrtrg","gtrrgrtg"},
                {"2","3","fewfe","собственник","пекп"},
                {"4","11","fewfe","пекп56п","пекп"},
                {"4","22","fewfe","собственник","пекп"},
                {"5","32","fewfe","пекп56п","пекп"},
            };
            string[] a = ds.ArrayStrEntrance(DataTable);
            int[] res = ds.ArraySumFlatsInEntrance(DataTableobj, a);
            int[] wait = { 1, 2, 1 };
            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestArrayCountOwnOrRent()
        {
            object[,] DataTable =
            {
                {"ggrtgrtg","gtrgrtgtr","gtrtgr","gtrtrg","gtrrgrtg"},
                {"2","3","fewfe","собственник","пекп"},
                {"4","11","fewfe","пекп56п","пекп"},
                {"4","22","fewfe","собственник","пекп"},
                {"5","32","fewfe","пекп56п","пекп"},
            };
            int[] res = ds.ArrayCountOwnOrRent(DataTable);
            int[] wait = { 2, 2 };
            CollectionAssert.AreEqual(wait, res);
        }


        [TestMethod]
        public void TestSortMin()
        {
            string[,] DataTable =
            {
                {"ggrtgrtg","gtrgrtgtr","gtrtgr","gtrtrg","gtrrgrtg"},
                {"2","3","fewfe","собственник","пекп"},
                {"4","11","fewfe","пекп56п","пекп"},
                {"4","22","fewfe","собственник","пекп"},
                {"5","32","fewfe","пекп56п","пекп"},
            };
            string[,] res = ds.SortMin(DataTable, 0);
            string[,] wait =
            {
                {"ggrtgrtg","gtrgrtgtr","gtrtgr","gtrtrg","gtrrgrtg"},
                {"2","3","fewfe","собственник","пекп"},
                {"4","11","fewfe","пекп56п","пекп"},
                {"4","22","fewfe","собственник","пекп"},
                {"5","32","fewfe","пекп56п","пекп"},
            };
            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestSortMax()
        {
            string[,] DataTable =
            {
                {"ggrtgrtg","gtrgrtgtr","gtrtgr","gtrtrg","gtrrgrtg"},
                {"2","3","fewfe","собственник","пекп"},
                {"4","11","fewfe","пекп56п","пекп"},
                {"4","22","fewfe","собственник","пекп"},
                {"5","32","fewfe","пекп56п","пекп"},
            };
            string[,] res = ds.SortMax(DataTable, 0);
            string[,] wait =
            {
                {"ggrtgrtg","gtrgrtgtr","gtrtgr","gtrtrg","gtrrgrtg"},
                {"5","32","fewfe","пекп56п","пекп"},
                {"4","11","fewfe","пекп56п","пекп"},
                {"4","22","fewfe","собственник","пекп"},
                {"2","3","fewfe","собственник","пекп"},
            };
            CollectionAssert.AreEqual(wait, res);
        }


        [TestMethod]
        public void TestSortMinOwnOrRent() // собственники
        {
            string[,] DataTable =
            {
                {"ggrtgrtg","gtrgrtgtr","gtrtgr","gtrtrg","gtrrgrtg"},
                {"2","3","fewfe","собственник","пекп"},
                {"4","11","fewfe","пекп56п","пекп"},
                {"4","22","fewfe","собственник","пекп"},
                {"5","32","fewfe","пекп56п","пекп"},
            };
            string[,] res = ds.SortMinOwnOrRent(DataTable, 3);
            string[,] wait =
            {
                {"ggrtgrtg","gtrgrtgtr","gtrtgr","gtrtrg","gtrrgrtg"},
                {"2","3","fewfe","собственник","пекп"},
                {"4","22","fewfe","собственник","пекп"},
                {"4","11","fewfe","пекп56п","пекп"},
                {"5","32","fewfe","пекп56п","пекп"},
            };
            CollectionAssert.AreEqual(wait, res);
        }


        [TestMethod]
        public void TestSortSortMaxOwnOrRent()
        {
            string[,] DataTable =
            {
                {"ggrtgrtg","gtrgrtgtr","gtrtgr","gtrtrg","gtrrgrtg"},
                {"2","3","fewfe","собственник","пекп"},
                {"4","11","fewfe","пекп56п","пекп"},
                {"4","22","fewfe","собственник","пекп"},
                {"5","32","fewfe","пекп56п","пекп"},
            };
            string[,] res = ds.SortMaxOwnOrRent(DataTable, 3);
            string[,] wait =
            {
                {"ggrtgrtg","gtrgrtgtr","gtrtgr","gtrtrg","gtrrgrtg"},
                {"4","11","fewfe","пекп56п","пекп"},
                {"5","32","fewfe","пекп56п","пекп"},
                {"2","3","fewfe","собственник","пекп"},
                {"4","22","fewfe","собственник","пекп"},
            };
            CollectionAssert.AreEqual(wait, res);
        }


        [TestMethod]
        public void TestSearch()
        {
            string[,] DataTable =
            {
                {"ggrtgrtg","gtrgrtgtr","gtrtgr","gtrtrg","gtrrgrtg","htrhtrhtrh","grthrthr"},
                {"2","3","Карпова Карина Николаевна","акуп","пекп","gergee","greege"},
                {"4","11","Илюхин Вадим Георгиевич","Иакуау","пекп","Greger","gergerg"},
                {"4","22","Попов Алеша Максимович","мпкепекп","пекп","regegreg","gregerger"},
                {"5","32","Васильев Василий Васильевич","пекп56п","пекп","Rgeeg","ergegreg"},


            };
            string[] res = ds.Search(DataTable, "Попов Алеша Максимович");
            string[] wait = { "4", "22", "Попов Алеша Максимович", "мпкепекп", "пекп", "regegreg", "gregerger" };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
