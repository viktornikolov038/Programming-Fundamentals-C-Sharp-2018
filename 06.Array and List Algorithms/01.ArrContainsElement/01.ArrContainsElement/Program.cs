using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ArrContainsElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var numberToFind = int.Parse(Console.ReadLine());
            var found = false;
            foreach (var number in numbers)
            {
                if (number == numberToFind)
                {
                    Console.WriteLine("yes");
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("no");
            }
        }
    }
}
