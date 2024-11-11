using Tyuiu.NoskovVI.Sprint4.Task6.V20.Lib;
namespace Tyuiu.NoskovVI.Sprint4.Task6.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalcTest()
        {
            var ds = new DataService();
            string[] array = new string[] { "Математика", "Физика", "Химия", "Биология", "География", "История", "Литература" };
            string[] wait = new string[] { "Физика", "Химия", "Биология", "География", "История" };
            CollectionAssert.AreEqual(wait, ds.Calculate(array));
        }
    }
}