using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер запаса в метрах");
            int totalInM;
            totalInM = Convert.ToInt16(Console.ReadLine());
            if (totalInM <= 0)
            {
                Console.WriteLine("Размер запаса должен быть положительным");
                return;
            }

            Console.WriteLine("Введите норму расхода в см");
            int partInCm;
            partInCm = Convert.ToInt16(Console.ReadLine());
            if (partInCm <= 0)
            {
                Console.WriteLine("Норма расхода должна быть положительной");
                return;

            }
            int quantity = totalInM * 100 / partInCm;
            int deficit = totalInM * 100 % partInCm;
            Console.WriteLine("Количество изделия {0} шт, Остаток {1} см", quantity, deficit);




        }

    }
}
