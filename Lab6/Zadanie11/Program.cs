using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie11
{
    class Program
    {
        static void Main(string[] args)
        {
            int s;
            s = 0;

            int A;
                        
            A = Convert.ToInt32(Console.ReadLine());
            if (A < -100)
            {
                Console.WriteLine("Значение A должно быть в интервале [-100, 500]");
            }
            else 

            if (A>500)
            {
                Console.WriteLine("Значение A должно быть в интервале [-100, 500]");
            }
                      

            while (A <= 500)
            {
                s = s + A;
                A++;
            }
            Console.WriteLine(s);

        }
    }
}
