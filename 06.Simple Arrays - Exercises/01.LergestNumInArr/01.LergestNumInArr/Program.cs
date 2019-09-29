using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LergestNumInArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int largestNum = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                numbers[i] = currentNum;
                if (numbers[i] > largestNum)
                {
                    largestNum = numbers[i];
                }
            }
            Console.WriteLine(largestNum);
        }
    }
}
