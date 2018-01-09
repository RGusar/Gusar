using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z5
{
    class Program
    {
        static void Main(string[] args)
        {
            int P;
            P = Convert.ToInt32(Console.ReadLine());

            int Q;
            Q= Convert.ToInt32(Console.ReadLine());

            String data;
            data = Console.ReadLine();
            String[] arr = data.Split(' ');

            String T;

            T = arr[P];
            arr[P] = arr[Q];
            arr[Q] = T;

            int i;
            i = 0;

            while (i < arr.Length)
            {
                Console.Write(arr[i]);
                i++;
            }
        }
    }
}
