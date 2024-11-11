using Tyuiu.NoskovVI.Sprint4.Task2.V28.Lib;
namespace Tyuiu.NoskovVI.Sprint4.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalcTest()
        {
            var ds = new DataService();
            int[] array = new int[] { 2, 7, 5, 6, 9, 5, 4, 3, 2, 1, 2, 3 };
            int wait = 7 + 5 + 9 + 5 + 3 + 1 + 3;
            Assert.AreEqual(wait, ds.Calculate(array));
        }
    }
}