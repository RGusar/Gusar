using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int edge = int.Parse(Console.ReadLine());
            if (edge <= 0)
            {
                Console.WriteLine("Значение edge должно быть положительным");
                return;
            }
            int result;
            result = (int)Math.Pow(edge, 3);

            Console.WriteLine(result);
        }
    }
}
