using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ArraysMultiply
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            NewLines(5);
            var othernumbers = "1 2 3 4 5 6       7 ";
            string[] parts = othernumbers.Split(
                new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < parts.Length; i++)
            {
                Console.WriteLine(parts[i]);
            }
        }
        public static void NewLines(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Environment.NewLine);
            }
        }
    }
}
