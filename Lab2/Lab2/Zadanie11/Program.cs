using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie11
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            x = Convert.ToInt32(Console.ReadLine());
            if (x<0)
            {
                Console.WriteLine("Значение х должно быть положительным");
                return;
                            }
            double a;
            a = Math.Sqrt(x);
            Console.WriteLine("{0:F4}", a);
        }
    }
}
