using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ListExe
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var firstListSum = 0;
            foreach (var number in firstList)
            {
                firstListSum += number;
            }

            var secondList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            
            for (int i = 0; i < secondList.Count; i++)
            {
                for (int r = 0; r < firstList.Count; r++)
                {
                    secondList.Remove(firstList[r]);
                }
                
            }

            


            var secondListSum = 0;
            foreach (var number in secondList)
            {
                secondListSum += number;
             
            }
            if (firstListSum == secondListSum)
            {
                Console.WriteLine($"Yes. Sum: {firstListSum}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(firstListSum - secondListSum)}");
            }
        }
    }
}
