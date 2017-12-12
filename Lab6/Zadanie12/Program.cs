using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = -10;

            int s;
            s = 0;

            int B;
            B = Convert.ToInt32(Console.ReadLine());

            if (B < -10)
            { Console.WriteLine("Значение b должно быть в интервале [-10,10000]"); }
            else
                if (B > 10000)
            {
                                Console.WriteLine("Значение b должно быть в интервале [-10,10000]");
            }
            return;
            while (a<=B)
            {
                s = s + a;
                a++;
            }
            Console.WriteLine(s);
            
        }
    }
}
