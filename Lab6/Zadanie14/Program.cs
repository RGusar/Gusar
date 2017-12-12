using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie14
{
    class Program
    {
        static void Main(string[] args)
        {
            long a;
            a = Convert.ToInt64(Console.ReadLine());

            long b;
            b = Convert.ToInt64(Console.ReadLine());

            long m;
            m = 1;

            if (a < b)
                while (a < b)
                {
                    m = m * a;
                    Console.WriteLine(m);
                    a++;
                }
            else
                while (a >= b)
                {
                    m = b *m;
                    Console.WriteLine(m);
                    b++;
                }
            Console.Write(m);
        }
    }
}
