using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie18
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1;
            x1 = Convert.ToInt32(Console.ReadLine());

            int x2;
            x2 = Convert.ToInt32(Console.ReadLine());

            int x3;
            x3 = Convert.ToInt32(Console.ReadLine());

            int result;
            result = x1 * x2 + x1 * x3 + x2 * x3;

            Console.WriteLine(result);

        }
    }
}
