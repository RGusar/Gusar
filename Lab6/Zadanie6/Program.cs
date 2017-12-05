using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            long a;
            a = Convert.ToInt64(Console.ReadLine());

            long b;
            b = Convert.ToInt64(Console.ReadLine());

            if (a < b)
            while (a <= b)
                {
                    Console.WriteLine(a);
                    a = a + 1;
                } 

            else
             while (a >= b)
            {
                Console.WriteLine(b);
                b = b + 1;
                } 
                    
        }
    }
}
