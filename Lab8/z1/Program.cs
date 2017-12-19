using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = Convert.ToInt32(Console.ReadLine());

            String data;
            data = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(data))
            {
                Console.WriteLine("Строка пуста");
                return;
            }
            String[] arr = data.Split(' ');
            if (a < 0 || arr.Length <= a)
            {
                Console.WriteLine("Число A должно быть в интервале [0, размер массива)");
                return;
            }
            Console.WriteLine(arr[a]);

        }
    }
}
