using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            int base1 = int.Parse(Console.ReadLine());
            if (base1 <= 0)
            {
                Console.WriteLine("Значение base1 должно быть положительным");
                return;
            }
            int height = int.Parse(Console.ReadLine());
            if (height <= 0)
            {
                Console.WriteLine("Значение height должно быть положительным");
                return;
            }


            double area;
            area = (double) base1 * height / 2;
           

            Console.WriteLine("{0:F2}",area);
        }
    }
}
