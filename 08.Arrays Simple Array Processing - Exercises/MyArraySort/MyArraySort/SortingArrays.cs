using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArraySort
{
    class SortingArrays
    {
        public static void Main()
        {
            var unsortedNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var swapped = true;
            while (swapped)
            {
                swapped = false;
                for (int i = 0; i < unsortedNumbers.Length - 1; i++)
                {
                   
                    if (unsortedNumbers[i] > unsortedNumbers[i + 1])
                    {
                        var temp = unsortedNumbers[i];
                        unsortedNumbers[i] = unsortedNumbers[i + 1];
                        unsortedNumbers[i + 1] = temp;
                        swapped = true;
                    }
                    
                }
            }

            var sortedNumbers = string.Join(" ", unsortedNumbers);
            Console.WriteLine(sortedNumbers);
        }
    }
}
