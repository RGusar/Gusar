using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            A = Convert.ToInt32(Console.ReadLine());

            int B;
            B = Convert.ToInt32(Console.ReadLine());

            if (A > B)
            {
                Console.WriteLine("Первое");
            }
            else {
                Console.WriteLine("Второе");

            }
        }
    }
}
