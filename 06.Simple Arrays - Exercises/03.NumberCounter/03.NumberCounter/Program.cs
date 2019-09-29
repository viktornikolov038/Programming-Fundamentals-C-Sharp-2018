﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.NumberCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var element = int.Parse(Console.ReadLine());
            var counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (element == numbers[i])
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
