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
            string[] array = new string[] { "����������", "������", "�����", "��������", "���������", "�������", "����������" };
            string[] wait = new string[] { "������", "�����", "��������", "���������", "�������" };
            CollectionAssert.AreEqual(wait, ds.Calculate(array));
        }
    }
}