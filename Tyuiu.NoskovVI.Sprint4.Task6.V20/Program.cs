using Tyuiu.NoskovVI.Sprint4.Task6.V20.Lib;
namespace Tyuiu.NoskovVI.Sprint4.Task6.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ds = new DataService();
            string[] array = new string[] { "Математика", "Физика", "Химия", "Биология", "География", "История", "Литература" };
            Console.Title = "Спринт #4 | Выполнил: Носков В. И. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Носков Виталий Игоревич | ПКТб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Выведите элементы массива, длина которых меньше 10 символов             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Математика, Физика, Химия, Биология, География, История, Литература     *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                        *");
            Console.WriteLine("***************************************************************************");

            var newArray = ds.Calculate(array);
            Console.WriteLine("Массив после операций: ");
            for (int i = 0; i <  newArray.Length; i++)
            {
                Console.WriteLine($"{newArray[i]}");
            }


        }
    }
}
