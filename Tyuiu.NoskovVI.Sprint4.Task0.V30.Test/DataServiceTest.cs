using Tyuiu.NoskovVI.Sprint4.Task0.V30.Lib;
namespace Tyuiu.NoskovVI.Sprint4.Task0.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SumArrayTest()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };
            int wait = 8 + 4 + 6 + 4 + 6 + 2;
            Assert.AreEqual(wait, ds.GetSumEvenArrEl(array));
        }
    }
}