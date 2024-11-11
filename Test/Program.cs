namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = "348561792486";
            int[,] matrix = new int[4, 3];
            int sumEven = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix[j,i] = int.Parse(value[i * 4 + j].ToString());
                    Console.WriteLine(matrix[j, i]);
                    if (matrix[j,i] % 2 == 0)
                    {
                        sumEven += matrix[j, i];
                    }
                }
            }
            Console.WriteLine(sumEven);
        }
    }
}
