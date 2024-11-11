using Tyuiu.NoskovVI.Sprint4.Task7.V25.Lib;
namespace Tyuiu.NoskovVI.Sprint4.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalcTest()
        {
            var ds = new DataService();
            int n = 4;
            int m = 3;
            string value = "348561792486";
            int wait = 4 + 8 + 6 + 2 + 4 + 8 + 6;
            Assert.AreEqual(wait, ds.Calculate(n,m, value));
        }
    }
}