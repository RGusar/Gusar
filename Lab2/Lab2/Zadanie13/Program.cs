using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie13
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            x = Convert.ToInt64(Console.ReadLine());

            if (x>61)
            {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                return;
            }

           double result;
            result = 3 * Math.Sqrt(61-x);

            Console.WriteLine("{0:F4}", result);
        }
    }
}
