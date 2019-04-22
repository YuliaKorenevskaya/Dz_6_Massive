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
            int[,] mass = new int[3, 3] { {1,2,3}, { 4, 5, 6 }, { 7, 8, 9} };

            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                int max = mass[i, 1];

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{mass[i, j]} ");
                    if (mass[i, j]> max)
                    {
                        max = mass[i, j];
                    }
                }
                Console.WriteLine($" max{i+1} = {max}");
            }
            Console.ReadKey();
        }
    }
}