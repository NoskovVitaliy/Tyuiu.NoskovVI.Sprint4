using Tyuiu.NoskovVI.Sprint4.Task0.V30.Lib;

namespace Tyuiu.NoskovVI.Sprint4.Task0.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Носков В. И. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Носков Виталий Игоревич | ПКТб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив, найти суммы четных элементов.      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*{9, 8, 4, 6, 9, 4, 3, 6, 1, 2}                                           *");
            Console.WriteLine("\n***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetSumEvenArrEl(array));

        }
    }
}
