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
            int totalInM = Console.Read();
            if (totalInM<=0);
            {
                Console.WriteLine("Размер запаса должен быть положительным");
                return;
            }
            
            Console.WriteLine("Введите норму расхода в см");
            int PartInCm = Console.Read();
            if (PartInCm <= 0);
            {
                Console.WriteLine("Норма расхода должна быть положительной");
                return;
            }


        }
        
    }
}
