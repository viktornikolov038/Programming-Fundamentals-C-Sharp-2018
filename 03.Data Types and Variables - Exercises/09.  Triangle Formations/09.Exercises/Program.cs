using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());
            int sideC = int.Parse(Console.ReadLine());
            int biggestSide = Math.Max(sideA, Math.Max(sideB, sideC));
            if (biggestSide < sideA + sideB && biggestSide < sideA + sideC && biggestSide < sideB + sideC)
            {
                Console.WriteLine("Triangle is valid.");
                int sideAPow = sideA * sideA;
                int sideBPow = sideB * sideB;
                int sideCPow = sideC * sideC;
                if (sideAPow == sideBPow + sideCPow)
                {
                    Console.WriteLine("Triangle has a right angle between sides b and c");
                }
                else if (sideBPow == sideAPow + sideCPow)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and c");
                }
                else if (sideCPow == sideAPow + sideBPow)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and b");

                }
                else
                {
                    Console.WriteLine("Triangle has no right angles");
                }

            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
            }
        }
    }
}
