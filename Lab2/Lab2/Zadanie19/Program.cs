using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie19
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialVelocity;
            initialVelocity = Convert.ToInt32(Console.ReadLine());
            if (initialVelocity < 0)
            {
                Console.WriteLine("Начальная скорость должно быть неотрицательна");
                return;
            }

            int time;
            time = Convert.ToInt32(Console.ReadLine());
            if (time <= 0)
            {
                Console.WriteLine("Время должно быть положительным");
                return;
            }

            int acceleration;
            acceleration = Convert.ToInt32(Console.ReadLine());

            int distance;
            distance = initialVelocity * time + acceleration * time * time / 2;

            Console.WriteLine("{0:F2}", distance);
        }
        }
}
