using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var result = numbers
                .OrderByDescending(num => num)
                .Take(3)
                .ToArray();
           
                Console.WriteLine(string.Join(" ", result));
            

        }
    }
}
