using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Double velocity1;
            velocity1 = Convert.ToDouble (Console.ReadLine());
            if (velocity1<0)
            {
                Console.WriteLine("Скорость должна быть неотрицательна");
                return;
            }

            Double velocity2;
            velocity2 = Convert.ToDouble(Console.ReadLine());
            if (velocity2 < 0)
            {
                Console.WriteLine("Скорость должна быть неотрицательна");
                return;
            }

            Double distance;
            distance = Convert.ToDouble(Console.ReadLine());
            if (distance < 0)
            {
                Console.WriteLine("Дистанция должна быть неотрицательна");
                return;
            }

            Double time;
            time = Convert.ToDouble(distance / (velocity1 + velocity2));
            Console.WriteLine("{0:F2}",time);
        }
    }
}
