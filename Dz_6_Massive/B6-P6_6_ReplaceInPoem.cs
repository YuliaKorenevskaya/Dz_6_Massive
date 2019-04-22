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
            Console.WriteLine("Напишите стишок через <;> :");
            string str = Console.ReadLine();

            str = str.Replace("о", "а");
            str = str.Replace("л", "ль");
            str = str.Replace("ть", "т");

            string[] split = str.Split(new Char[] { ';' });
            foreach (string s in split)
            {
                if (s.Trim() != "")
                {
                    Console.WriteLine(s);
                }
            }

           // for (int i = 0; i < str.Length; i++)
           // {
            //    if (str[i] != ';')
              //  {
              //      Console.Write(str[i]);
              //  }
              //  else
               // {
                //    Console.WriteLine();
               // }
           // }

            Console.ReadKey();
        }
    }
}