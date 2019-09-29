using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int Overflowed = n / 256;


            if (Overflowed == 0)
            {
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine(n % 256);
                Console.WriteLine("Overflowed {0} times", Overflowed);
            }
            
        }
    }
}

