using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.IncreasingSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            bool isTrue = true;
            int previsious = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] <= previsious)
                {
                    isTrue = false;
                }
                previsious = numbers[i];
            }
            if (isTrue)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
