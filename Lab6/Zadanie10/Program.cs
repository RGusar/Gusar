using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = 100;

            int i;
            i = 100;

            int s;
            s = 0;

            Console.Write("Ход решения");
            while (i <= 500)
            {


                s = s + a;
                a = a + 1;
                i++;
                Console.Write(" "+s);
            }
            Console.WriteLine();
            Console.WriteLine("Ответ" + s);

        }
    }
}
