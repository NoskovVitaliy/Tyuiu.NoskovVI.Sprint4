using Tyuiu.NoskovVI.Sprint4.Task1.V23.Lib;
namespace Tyuiu.NoskovVI.Sprint4.Task1.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalcTest()
        {
            var ds = new DataService();
            int[] array = new int[] { 9, 9, 5, 6, 5, 4, 4, 5, 8, 7, 6, 8, 7, 5, 9, 9, 9 };
            int wait = 6 + 4 + 4 + 8 + 6 + 8;
            Assert.AreEqual(wait, ds.Calculate(array));
        }
    }
}