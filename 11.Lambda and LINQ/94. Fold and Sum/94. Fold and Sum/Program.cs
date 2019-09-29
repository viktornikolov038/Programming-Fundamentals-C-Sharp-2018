using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _94.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var k = numbers.Length / 4;
            var firstPartupperCase = numbers
                .Take(k)
                .Reverse()
                .ToArray();
            var secondPartUpperCase = numbers
                .Reverse()
                .Take(k)
                .ToArray();
            var upperCase = firstPartupperCase.Concat(secondPartUpperCase).ToArray();

            var lowerCase = numbers
                .Skip(k)
                .Take(2 * k)
                .ToArray();
            var result = new int[upperCase.Length];
            for (int i = 0; i < upperCase.Length; i++)
            {
                result[i] = upperCase[i] + lowerCase[i];
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
