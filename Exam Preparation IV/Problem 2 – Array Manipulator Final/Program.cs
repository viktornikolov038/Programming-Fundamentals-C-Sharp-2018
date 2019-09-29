using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Manipulator_Done
{
    class Program
    {
        public static void Main()
        {
            var array = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                var commandParams = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var command = commandParams[0];
                switch (command)
                {
                    case "exchange":
                        var index = int.Parse(commandParams[1]);
                        array = Exchange(array, index);
                        break;
                    case "max":
                    case "min":
                        var maxOrMin = command;
                        var evenOrOdd = commandParams[1];

                        FindMaxOrMinEvenOrOddElement(array, maxOrMin, evenOrOdd);
                        break;
                    case "first":
                    case "last":
                        var firstOrLast = command;
                        var count = int.Parse(commandParams[1]);
                        evenOrOdd = commandParams[2];

                        FindFirstOrLastOddOrEvenElements(array, firstOrLast, count, evenOrOdd);
                        break;

                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", array));
        }

        private static void FindFirstOrLastOddOrEvenElements(int[] array, string firstOrLast, int count, string evenOrOdd)
        {
            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            var evenOrOddParity = evenOrOdd == "even" ? 0 : 1;
            var evenOrOddElements = array.Where(a => a % 2 == evenOrOddParity);
            int[] foundElements;
            if (firstOrLast == "first")
            {
                foundElements = evenOrOddElements
                    .Take(count)
                    .ToArray();
            }
            else
            {
                foundElements = evenOrOddElements
                    .Reverse()
                    .Take(count)
                    .Reverse()
                    .ToArray();
            }

            Console.WriteLine("[{0}]", string.Join(", ", foundElements));

        }

        private static void FindMaxOrMinEvenOrOddElement(int[] array, string maxOrMin, string evenOrOdd)
        {
            var evenOrOddElementsParity = evenOrOdd == "even" ? 0 : 1;
            var evenOrOddElements = array.Where(a => a % 2 == evenOrOddElementsParity).ToArray();
            if (!evenOrOddElements.Any())
            {
                Console.WriteLine("No matches");
                return;
            }

            var maxOrMinElement = 0;
            if (maxOrMin == "max")
            {
                maxOrMinElement = evenOrOddElements.Max();
            }
            else
            {
                maxOrMinElement = evenOrOddElements.Min();
            }

            var maxOrMinIndex = Array.LastIndexOf(array, maxOrMinElement);
            Console.WriteLine(maxOrMinIndex);
        }

        private static int[] Exchange(int[] array, int index)
        {
            var isValidIndex = index >= 0 && index < array.Length;
            if (!isValidIndex)
            {
                Console.WriteLine("Invalid index");
                return array;
            }

            var leftPart = array.Take(index + 1);
            var rightPart = array.Skip(index + 1);
            var combinedArray = rightPart.Concat(leftPart).ToArray();
            return combinedArray;
        }
    }
}
