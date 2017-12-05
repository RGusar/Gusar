using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie9
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, i = 1, x = 7;
            while (i <= 9)
            {
                m = i * x;
                Console.WriteLine("{0}х{1}={2}",i,x,m);
                i++;
                            }
        }
    }
}
