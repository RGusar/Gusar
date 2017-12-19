using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    class Program
    {
        static void Main(string[] args)
        {
            string data;
            data = Console.ReadLine();

            String[] arr = data.Split(' ');
          
            int i;
            i = 0;

            while (i < arr.Length)
            {
                Console.WriteLine(arr[i] + " " + i);
                i++;
            }


        }
    }
}
