using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie7
{
    class Program
    {
        static void Main(string[] args)
        {
            double aInRad = double.Parse(Console.ReadLine());
            double aInGrad = aInRad * Math.PI / 180;
            Console.WriteLine("{0:F4}", aInGrad);
        }
    }
}
