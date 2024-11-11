using Tyuiu.NoskovVI.Sprint4.Task5.V21.Lib;
namespace Tyuiu.NoskovVI.Sprint4.Task5.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalcTest()
        {
            var ds = new DataService();
            int[,] matrix = new int[,] { { -1, -2, -3, -4, 2 }, { -5, 2, 2, 1, 2 }, { 1, 1, -8, -8, -6 }, { 2, 2, -5, -6, -7 }, { 2, 2, 2, 2, 2 } };
            int[,] wait = new int[,] { { -1, -2, -3, -4, 1 }, { -5, 1, 1, 1, 1 }, { 1, 1, -8, -8, -6 }, { 1, 1, -5, -6, -7 }, { 1, 1, 1, 1, 1 } };
            CollectionAssert.AreEqual(wait, ds.Calculate(matrix));
        }
    }
}