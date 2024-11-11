using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.NoskovVI.Sprint4.Task6.V20.Lib
{
    public class DataService : ISprint4Task6V20
    {
        public string[] Calculate(string[] array)
        {
            string[] NeededLenArray = Array.FindAll(array,str => str.Length<10);
            return NeededLenArray;
        }
    }
}
