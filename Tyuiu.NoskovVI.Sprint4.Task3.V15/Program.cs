using Tyuiu.NoskovVI.Sprint4.Task3.V15.Lib;
namespace Tyuiu.NoskovVI.Sprint4.Task3.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Носков В. И. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Носков Виталий Игоревич | ПКТб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив, найти количество нечетных элементов *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*{7, 4, 2, 5, 3 },\n {4, 3, 2, 5, 6 },\n {6, 3, 4, 7, 5 },\n {5, 7, 4, 3, 8 },\n {7, 8, 8, 5, 6 }*");
            int[,] array = new int[,] { {7, 4, 2, 5, 3 },

                                        {4, 3, 2, 5, 6 },

                                        {6, 3, 4, 7, 5 },

                                        {5, 7, 4, 3, 8 },

                                        {7, 8, 8, 5, 6 }};
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(array));

        }
    }
}
