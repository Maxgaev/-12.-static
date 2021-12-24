using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace Задание_12.Модификатор_static
{
 
        public static class Points
        {
            public static double l;
            public static double S;

            public static void Length(double r)
            {
                l = 2 * Math.PI * r;
                Console.WriteLine("Длина окружности L = {0:00}", l);
            }
            public static void Square(double r)
            {
                S = Math.PI * r * r;
                Console.WriteLine("Площадь круга S = {0:00}", S);
            }
            public static void Point(double x, double y, double r)
            {
                if (r >= Math.Sqrt(x * x + y * y))
                {
                    Console.WriteLine("Точка находится внутри круга");
                }
                else
                {
                    Console.WriteLine("Точка находится за пределами круга");
                }
            }
        }
    
}
