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
            int a;
            a = Convert.ToInt32(Console.ReadLine());

            int b;
            b = Convert.ToInt32(Console.ReadLine());

            int s;
            s = 0;

            if (a > b)
                while (b <= a)
                {
                    s = s + b;
                    b++;
                }
            else 
                while (a <= b)
                {
                    s = s + a;
                    a++;
                }
            Console.WriteLine(s);
            
        }
    }
}
