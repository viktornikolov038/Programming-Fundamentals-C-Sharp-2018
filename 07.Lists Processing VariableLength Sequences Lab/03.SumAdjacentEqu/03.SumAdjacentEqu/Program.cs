using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumAdjacentEqu
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            foreach (var item in numbers)
            {
                var currentNumber = numbers[i];
                var nextNumber = numbers[i + 1];
                if (currentNumber == nextNumber)
                {
                    numbers.RemoveAt(i);
                    numbers.RemoveAt(i + 1);
                    numbers.Insert(i, currentNumber + nextNumber);
                }
            }
            string result = string.Join(" ", numbers);
            Console.WriteLine(result);
        }
    }
}
