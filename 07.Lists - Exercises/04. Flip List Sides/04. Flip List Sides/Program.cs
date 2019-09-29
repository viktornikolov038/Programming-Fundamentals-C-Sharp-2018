using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Flip_List_Sides
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            //1 2 3 4 5 6 7 8 9 10 11
            //
            var adder = 2;

            var finalList = new List<int>();
            foreach (var item in numbers)
            {
                finalList.Add(0);
            }
            finalList[0] = numbers[0];
            
            for (int i = 1; i <= numbers.Count - 1; i++)
            {

                finalList[i] += numbers[numbers.Count-adder];
                adder++;             
            }
            if (numbers.Count % 2 != 0)
            {
                finalList[finalList.Count / 2] = numbers[numbers.Count / 2];
            }
            finalList[finalList.Count-1] = numbers[numbers.Count-1];
            var result = string.Join(" ", finalList);
            Console.WriteLine(result);
        }
    }
}
