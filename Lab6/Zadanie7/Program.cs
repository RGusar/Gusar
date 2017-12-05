using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = Convert.ToInt32(Console.ReadLine());

            int b;
            b=Convert.ToInt32(Console.ReadLine());

            if (a < b)
                while (a <= b)

                {
                    Console.WriteLine(a);
                    a = a + 1;
                }

            else
                while (a >= b)
                {
                    Console.WriteLine(a);
                    a = a - 1;
                }

            

        }
    }
}
