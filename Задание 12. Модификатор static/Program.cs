using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Задание_12.Модификатор_static
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите радиуc окружности:");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nВведите значение координаты X:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nВведите значение координаты Y:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Points.Length(r);
            Points.Square(r);
            Points.Point(x, y, r);
            Console.ReadKey();

        }
    

    }
}
