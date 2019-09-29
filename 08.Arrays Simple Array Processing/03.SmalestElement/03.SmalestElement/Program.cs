using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SmalestElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int minValue = int.MaxValue;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < minValue)
                {
                    minValue = input[i];
                }
            }
            Console.WriteLine(minValue);
        }
    }
}
