using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie9
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            a = Console.ReadLine();
            
            Console.Write("SELECT first_name, last_name, group \n" +
                "FROM students WHERE id =");
            Console.WriteLine("\'{0}\';",a);


                }
    }
}
