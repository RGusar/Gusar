using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z4
{
    class Program
    {
        static void Main(string[] args)
        {
            int B;
            B = Convert.ToInt32(Console.ReadLine());
            
            int E;
            E = Convert.ToInt32(Console.ReadLine());

           
            String data;
            data = Console.ReadLine();
            String[] arr = data.Split(' ');

            if (B < 0)
            {
                Console.WriteLine("Число B должно быть в интервале [0" + "-" + arr.Length +"]");
                return;
            }

            if (B > arr.Length)
            {
                Console.WriteLine("Число B должно быть в интервале [0" + "-" + arr.Length + "]");
                return;
            }
            
            if (E > arr.Length)
            {
                Console.WriteLine("Число B должно быть в интервале [0" + "-" + arr.Length + "]");
                return;
            }

            int i;
            i = 0;
           
            if (B > E)
            {
                i = E;
                while (i < B)
                {
                    Console.WriteLine(arr[i]);
                    i++;
                }
            }
            else
            {
                i = B;
                while (i <= E)
                {
                    Console.WriteLine(arr[i]);
                    i++;
                }
                    
            }
                    

            

            




        }
    }
}
