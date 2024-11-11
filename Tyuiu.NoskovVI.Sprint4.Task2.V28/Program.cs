using Tyuiu.NoskovVI.Sprint4.Task2.V28.Lib;
namespace Tyuiu.NoskovVI.Sprint4.Task2.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[12];
            var RandomNum = new Random();
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Носков В. И. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (генерация случайных чисел)                    *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Носков Виталий Игоревич | ПКТб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Случайный одномерный целочисл. массив, найти суммы нечетных элементов   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = RandomNum.Next(2,10);
            }

            Console.WriteLine("Элементы массива: ");
            for (int i = 0; i <array.Length; i++)
            {
                Console.Write($"{array[i]},");
            }

            Console.WriteLine("\nСумма нечетных элементов равна: " + ds.Calculate(array));
        }
    }
}
