using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    class Program
    {
        static void Main(string[] args)
        {
            String data;
            data = Console.ReadLine();

            String [] arr = data.Split(' ');

            int i;
            i = arr.Length - 1;

            while (i >= 0)
            {
                Console.WriteLine(arr[i]);
                i--;
            }
        }
    }
}
