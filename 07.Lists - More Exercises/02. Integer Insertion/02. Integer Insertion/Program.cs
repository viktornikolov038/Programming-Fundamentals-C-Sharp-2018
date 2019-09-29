using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Integer_Insertion
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var input = Console.ReadLine();
            while(input != "end")
            {
                input = Console.ReadLine();
                int positionInList = input[0] - 48;
                int kit = Convert.ToInt32(input);
                numbers.Insert(positionInList, kit);
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
