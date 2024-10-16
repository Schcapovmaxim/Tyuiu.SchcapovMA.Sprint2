﻿using Tyuiu.SchcapovMA.Sprint2.Task1.V18.Lib;
namespace Tyuiu.SchcapovMA.Sprint2.Task1.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a = 155;
            int b = 696;
            int c = 242;
            int d = 541;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            Console.Title = "Спринт #2 | Выполнил: Щапов М.А. | ИБКСб-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Щапов Максим Александрович | ИБКСб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз в         *");
            Console.WriteLine("*  выражении) и логических операций (|, &, ||, &&, !, ^,                  *");
            Console.WriteLine("* последовательность операций не должна нарушаться), а также              *");
            Console.WriteLine("* арифметических выражений, которая вернет логическую последовательность  *");
            Console.WriteLine("* (массив): (True, True, True, False, True, False), при a = 155, b = 696, *");
            Console.WriteLine("* c = 242, d = 541                                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" a = " + a);
            Console.WriteLine(" b = " + b);
            Console.WriteLine(" c = " + c);
            Console.WriteLine(" d = " + d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            for(int i = 0; i < 6; i ++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
