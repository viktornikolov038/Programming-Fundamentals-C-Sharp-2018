using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AverageChar
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .ToList();
            var sum = 0;
            var lettersCounter = 0;
            
            for (int i = 0; i < input.Count; i++)
            {
                foreach (var letter in input[i])
                {
                    sum += (int)letter;
                    lettersCounter++;
                    
                }
            }
           
            var avarage = sum / lettersCounter;
            var avarageAsSymbol = Convert.ToChar(avarage);
            var avarageUpper = char.ToUpper(avarageAsSymbol);
            for (int i = 0; i < input.Count - 1; i++)
            {
                foreach (var letter in input[i])
                {
                    sum += (int)letter;
                    lettersCounter++;
                    Console.Write(letter);                   
                }
                Console.Write(avarageUpper);
            }
            Console.Write(input[input.Count - 1]);
            Console.WriteLine();
        }
    }
}
