using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Append_Lists2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split('|')
                .ToList();
            var result = new List<string>();
            for (int i = input.Count - 1; i >= 0; i--)
            {
                result = input[i].Split(' ').ToList();
                Console.WriteLine(result[i]);
            }
        }
    }
}
