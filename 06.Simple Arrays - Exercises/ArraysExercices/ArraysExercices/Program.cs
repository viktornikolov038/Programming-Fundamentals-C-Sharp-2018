using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExercices
{
    class Program
    {
        public static void Main()
        {
            //var n = int.Parse(Console.ReadLine());
            //var numbers = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    var number = int.Parse(Console.ReadLine());
            //    numbers[i] = number;
            //}
            //var maxValue = int.MinValue;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > maxValue)
            //    {
            //        maxValue = numbers[i];
            //    }
            //}
            //Console.WriteLine(maxValue);





            //var numbers = Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //    .ToArray();
            //var isContained = int.Parse(Console.ReadLine());
            //var counter = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] == isContained)
            //    {
            //        counter++;
            //    }
            //}
            //Console.WriteLine(counter);

            var numbers = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToArray();
            bool isTrue = true;
            int previsious = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] <= previsious)
                {
                    isTrue = false;
                }
                previsious = numbers[i];
            }
            if (isTrue)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
