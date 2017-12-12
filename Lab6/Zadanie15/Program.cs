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
            double sm3;
            sm3 = 0;

            double i;
            i = 20;

            while (i <= 40)
            {
                sm3 =sm3+ i*i*i;
                i++;
                 }
            Console.WriteLine(sm3);

        }
    }
}
