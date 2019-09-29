using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LetterRepetition
{
    class Program
    {
        public static void Main()
        {

            var input = Console.ReadLine();
            var result = new Dictionary<char, int>();
            foreach (var letter in input)
            {
                
                if (!result.ContainsKey(letter))
                {
                    result[letter] = 0;
                }
                result[letter]++;
            }
            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
