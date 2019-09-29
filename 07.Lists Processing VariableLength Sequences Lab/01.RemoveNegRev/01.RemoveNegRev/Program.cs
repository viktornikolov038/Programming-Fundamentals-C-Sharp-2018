using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.RemoveNegRev
{
    class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.RemoveAt(i);
                    i--;
                }
            }
            numbers.Reverse();
            if (numbers.Count <= 0)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                string result = string.Join(" ", numbers);
                Console.WriteLine(result);
            }
        }
    }
}
