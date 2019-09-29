using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Numbers
{
    class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ' }
                , StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();
            var avarage = numbers.Average();
            var greaterThanAvg = new List<long>();
            foreach (var number in numbers)
            {
                if (number > avarage)
                {
                    greaterThanAvg.Add(number);
                }
            }

            var count = greaterThanAvg.Count();

            var result = greaterThanAvg
                .OrderByDescending(a => a)
                .ToList();

                if (count == 0)
                {
                    Console.WriteLine("No");
                }
                else if (count < 5)
                {
                    Console.WriteLine(string.Join(" ", result));
                }
                else
                {
                    result = result.Take(5).ToList();
                    Console.WriteLine(string.Join(" ", result));
                }
            }
            
        }
    }

