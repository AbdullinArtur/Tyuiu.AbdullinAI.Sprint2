using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AbdullinAI.Sprint2.Task4.V13.Lib;


namespace Tyuiu.AbdullinAI.Sprint2.Task4.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Абудллин А. И.  | АСОиУБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Абдуллин А. И. | АСОиУБ-23-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с              *");
            Console.WriteLine("* использованием оператора, где пользователь вводит значение переменных   *");
            Console.WriteLine("* x,y с клавиатуры, если sqrt(x) * 3 > y * 2 - 20, то z = x + 10y - (1/x) *");
            Console.WriteLine("* иначе (x^2 + cos(y)^2 + 13) / y^2 - sin(y)^2 + 9                        *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            Console.WriteLine("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());        

            Console.WriteLine("Введите значение y");
            double y = Convert.ToDouble(Console.ReadLine());
            





            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.Calculate(x, y);
            Console.WriteLine("Результат: {0}", res);
            Console.ReadKey();
        }
    }
}
