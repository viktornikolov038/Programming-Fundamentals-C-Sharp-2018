using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.OddNumInOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0 && i % 2 != 0)
                {
                    Console.WriteLine("Index {0} -> {1}",i,numbers[i]);
                }
            }
        }
    }
}
