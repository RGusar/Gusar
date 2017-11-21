using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            int b;
            b=Convert.ToInt32(Console.ReadLine());
            if (a>b)
            {
                Console.WriteLine("A не должно быть больше B");
                return;
            }
            Console.WriteLine(a);
            while (a < b)
            {
               a = a + 1;
               Console.WriteLine(a);

            }

        }
    }
}
