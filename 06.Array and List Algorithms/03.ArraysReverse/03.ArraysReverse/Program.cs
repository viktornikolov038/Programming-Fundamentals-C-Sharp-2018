using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ArraysReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                var leftIndex = i;
                var rightIndex = numbers.Length - 1 - i;
                var temp = numbers[leftIndex];
                numbers[leftIndex] = numbers[rightIndex];
                numbers[rightIndex] = temp;
                
            }
            var revesedResult = string.Join(" ", numbers);
            Console.WriteLine(revesedResult);
            // same as 
            //var reversedWithMethod = numbers.Reverse().ToArray();
            //Console.WriteLine(string.Join(" ",reversedWithMethod));

        }
    }
}
