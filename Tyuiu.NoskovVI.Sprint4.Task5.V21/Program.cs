using Tyuiu.NoskovVI.Sprint4.Task5.V21.Lib;
namespace Tyuiu.NoskovVI.Sprint4.Task5.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ds = new DataService();
            var RandomNum = new Random();
            int[,] matrix = new int[5,5];
            Console.Title = "Спринт #4 | Выполнил: Носков В. И. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (генерация случайных чисел)                     *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Носков Виталий Игоревич | ПКТб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов                     *");
            Console.WriteLine("* заполненный случайными значениями в диапазоне от -8 до 2.               *");
            Console.WriteLine("* Заменить положительные элементы на 1.                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = RandomNum.Next(-8, 3);
                }
            }

            Console.WriteLine("Элементы матрицы до операций: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]},");
                }
            }
            var newMatrix = ds.Calculate(matrix);
            Console.WriteLine("\nЭлементы матрицы после операций: ");
            for (int i = 0; i < newMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < newMatrix.GetLength(1); j++)
                {
                    Console.Write($"{newMatrix[i, j]},");
                }
            }

        }
    }
}
