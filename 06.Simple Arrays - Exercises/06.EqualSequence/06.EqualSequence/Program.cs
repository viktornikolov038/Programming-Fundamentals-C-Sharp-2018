using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.EqualSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            bool areEqual = false;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] != numbers[i])
                {
                    areEqual = false;
                    break;
                }
                else
                {
                    areEqual = true;
                }
            }
            if (areEqual == false)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }
    }
}
