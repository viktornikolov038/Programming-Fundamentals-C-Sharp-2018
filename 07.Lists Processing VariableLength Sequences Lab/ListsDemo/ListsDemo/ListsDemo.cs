using System;
using System.Collections.Generic;
using System.Linq;
namespace ListsDemo
{
    class ListsDemo
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            numbers.Sort();
            numbers.Reverse();

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}
