using Tyuiu.SchcapovMA.Sprint2.Task4.V13.Lib;
namespace Tyuiu.SchcapovMA.Sprint2.Task4.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Title = "Спринт #2 | Выполнил: Щапов М.А. | ИБКСб-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Щапов Максим Александрович | ИБКСб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с              *");
            Console.WriteLine("* использованием тернарного оператора, где пользователь вводит значение   *");
            Console.WriteLine("* переменных x,y с клавиатуры,если √x*3 > y*2 - 20, то z = x + 10*y-(1/x) *");
            Console.WriteLine("* иначе (x^2+cos(y^2)+13)/(y^2-sin(y^2)+9). Ответ округлите до 3 знаков.  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            Console.WriteLine("* Введите значение переменной X:                                          *");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("* Введите значение переменной Y:                                          *");
            double y = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x, y);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Значение функции: " + res);
            Console.ReadKey();
        }
    }
}
