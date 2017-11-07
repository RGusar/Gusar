using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie15
{
    class Program
    {
        static void Main(string[] args)
        {
            double C;
            C = Convert.ToDouble(Console.ReadLine());   
            if (C< -273.15)
                {
                Console.WriteLine("Значение должно быть выше абсолютного нуля");
                return;
            }
            double F;
            F = 1.8*C + 32;
            Console.WriteLine("{0:F4}", F);

        }
    }
}
