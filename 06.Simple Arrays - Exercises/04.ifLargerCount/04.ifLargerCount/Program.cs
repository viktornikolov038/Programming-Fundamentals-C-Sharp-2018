using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ifLargerCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            var p = double.Parse(Console.ReadLine());
            var counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > p)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
