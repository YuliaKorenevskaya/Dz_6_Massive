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
            int[] mass = new int[5];
            Random r = new Random();

            for (int i = 0; i < 5; i++)
            {
                mass[i] = r.Next(20);
                Console.Write($"{ mass[i]} ");
            }

                for (int i = 0; i < 5; i++)
                {
                    for (int j = i + 1; j < 5; j++)
                    {
                        if (mass[i] > mass[j])
                        {
                            var x = mass[i];
                            mass[i] = mass[j];
                            mass[j] = x;
                        }
                    }
                }

            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{ mass[i]} ");
            }

            Console.ReadKey();
        }
    }
}