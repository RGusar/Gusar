using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int a;
            a=Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("Значение A должно быть неотрицательным");
                return;
            }

            string b;
            b = Console.ReadLine();

            int i;
            i = 0;
            Console.Write("\"");
            while (i < a)
            {
                Console.Write(b);
                i =i+1;

            }
            Console.WriteLine("\"");
        }

    }
}
