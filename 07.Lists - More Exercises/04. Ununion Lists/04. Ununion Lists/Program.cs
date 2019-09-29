using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Ununion_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var loop = int.Parse(Console.ReadLine());
            for (int i = 0; i < loop; i++)
            {
                var inputedLists = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
                for (int j = 0; j < inputedLists.Count; j++)
                {
                    for (int t = 0; t < numbers.Count; t++)
                    {
                        if (numbers[t] == inputedLists[j])
                        {
                            numbers.RemoveAt(t);
                        }
                    }
                    numbers.Add(inputedLists[j]);
                   
                }
            }
            string result = string.Join(" ", numbers);
            Console.WriteLine(result);
        }
    }
}
