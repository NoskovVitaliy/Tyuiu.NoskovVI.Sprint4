using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.NoskovVI.Sprint4.Task7.V25.Lib
{
    public class DataService : ISprint4Task7V25
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            int sumEven = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[j, i] = int.Parse(value[i * 4 + j].ToString());
                    if (matrix[j, i]%2 == 0)
                    {
                        sumEven += matrix[j, i];
                    }
                }
            }
            return sumEven;
        }
    }
}
