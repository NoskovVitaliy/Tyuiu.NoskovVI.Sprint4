using Tyuiu.NoskovVI.Sprint4.Task7.V25.Lib;
namespace Tyuiu.NoskovVI.Sprint4.Task7.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Носков В. И. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Носков Виталий Игоревич | ПКТб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр 348561792486.                         *");
            Console.WriteLine("* Преобразуйте ее в матрицу 4 на 3 и подсчитайте сумму четных чисел.      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int n, m;
            Console.WriteLine("Введите размерности матрицы по порядку: ");
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nВведите строку, которую надо преобразовать: ");
            string value = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма четных чисел равна: " + ds.Calculate(n,m,value));
        }
    }
}
