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
            int a;
            a=Convert.ToInt32(Console.ReadLine());
            int b;
            b=Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.Write("Значение a не должно быть больше b");
                return;
            }
            Console.WriteLine(b);
            while (a < b)
            {
                b = b - 1;
                Console.WriteLine(b);

            }

        }
    }
}
