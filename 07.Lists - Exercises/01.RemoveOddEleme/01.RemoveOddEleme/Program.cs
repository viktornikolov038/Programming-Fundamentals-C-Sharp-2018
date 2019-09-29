using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RemoveOddEleme
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .ToList();
            var result = new List<string>();
            for (int i = 0; i < input.Count; i++)
            {
                if (i % 2 != 0)
                {
                    result.Add(input[i]);
                }
            }

            for (int i = 0; i < result.Count; i++)
            {
                Console.Write(result[i]);
            }
            Console.WriteLine();
        }
    }
}
