using Tyuiu.NoskovVI.Sprint4.Task3.V15.Lib;
namespace Tyuiu.NoskovVI.Sprint4.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalcTest()
        {
            var ds = new DataService();
            int[,] array = new int[,] { {7, 4, 2, 5, 3 },

                                        {4, 3, 2, 5, 6 },

                                        {6, 3, 4, 7, 5 },

                                        {5, 7, 4, 3, 8 },

                                        {7, 8, 8, 5, 6 }};
            int wait = 13;
            Assert.AreEqual(wait, ds.Calculate(array));
        }
    }
}