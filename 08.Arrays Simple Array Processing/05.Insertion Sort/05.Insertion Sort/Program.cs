using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            //bcs i am lazy person :D but i am writing a comment ;(
            var inputList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            inputList.Sort();
            Console.WriteLine(string.Join(" ", inputList));
        }
    }
}
