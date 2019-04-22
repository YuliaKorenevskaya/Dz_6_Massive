using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_6_Massive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            //Console.WriteLine($"{str.Length}");
    
                if (str.Length > 13)
                {            
                   str = str.Substring(0, 13);
                   str = str.Insert(13, "...");
                }

                Console.Write($"{str}");

            Console.ReadKey();
        }
    }
}