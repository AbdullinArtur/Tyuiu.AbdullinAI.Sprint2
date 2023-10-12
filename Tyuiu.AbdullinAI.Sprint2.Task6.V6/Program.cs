using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AbdullinAI.Sprint2.Task6.V6.Lib;

namespace Tyuiu.AbdullinAI.Sprint2.Task6.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Абудллин А. И.  | АСОиУБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Абдуллин А. И. | АСОиУБ-23-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
            Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.   *");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Введите номер масти карты: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер достоинства карты: ");
            int y = Convert.ToInt32(Console.ReadLine());




            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            

            string res = ds.FindCardNameAndValue(x,y);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
