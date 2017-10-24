using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius = int.Parse(Console.ReadLine());
            if (radius <= 0)
            {
                Console.WriteLine("Значение radius должно быть положительным");
                return;
            }
            double volume;
            volume = Math.PI*4*Math.Pow(radius,3)/3;

            Console.WriteLine("{0:F4}",volume);        }
    }
}
