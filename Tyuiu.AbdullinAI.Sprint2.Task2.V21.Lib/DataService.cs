using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AbdullinAI.Sprint2.Task2.V21.Lib
{
    public class DataService : ISprint2Task2V21
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool a;

            if ((x == 3) && (y >= 3) && (y <= 7))
                a = true;
            else if (((x == 4) || (x == 5)) && (y >= 6) && (y <= 9))
                a = true;
            else if ((x == 6) && (y >= 5) && (y <= 9))
                a = true;
            else if (((x == 7) || (x == 8)) && (y >= 5) && (y <= 7))
                a = true;
            else if ((x == 9) && (((y >= 3) && (y <= 7)) || (y == 11 || y == 12)))
                a = true;
            else if ((x == 10) && ((y >= 3) && (y <= 12)))
                a = true;
            else if (((x == 11) || (x == 12)) && (y >= 3) && (y <= 11))
                a = true;
            else if ((x == 13) && (y >= 6) && (y <= 8))
                a = true;
            else
                a = false;

            return a;


            


           


           


          


            


            

            




        }

    }
}
