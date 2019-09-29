using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split('|')
                .ToList();
            for (int i = input.Count - 1; i >= 0; i--)              
            {
                
                var list = input[i].Split(
                new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).ToList();
                Console.Write(string.Join(" ",list) + " ");
            }
            Console.WriteLine();
            
        }
    }
}
