﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Z1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename;
            filename = "../../task6175/test1.txt";
            if (!File.Exists(filename))
            {
                Console.WriteLine("Файл не существует");
                return;
            }
            StreamReader reader;
            reader = new StreamReader(filename);
            if (reader.EndOfStream)
            {
                Console.WriteLine("Файл пуст");
            }
            else
            {
                String line = reader.ReadLine();
                Console.Write(line);
            }
           
              while (!reader.EndOfStream)

            {
                String line = reader.ReadLine();
                Console.Write(", " + line);
            }

            
        }
    }
}
        