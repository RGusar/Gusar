using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius = int.Parse(Console.ReadLine());
            if (radius <= 0)
            {
                Console.WriteLine("Значение edge должно быть положительным");
                return;
            }
            double circumference;
            circumference = Math.PI*2*radius;

            Console.WriteLine(circumference);
        }
    }
}
