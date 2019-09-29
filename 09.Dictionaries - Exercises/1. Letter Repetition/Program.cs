using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Letter_Repetition
{
    class Program
    {
        public static void Main()
        {
            var letters = new Dictionary<char, int>();
            var inputLine = Console.ReadLine();
            foreach (var letter in inputLine)
            {
                if (!letters.ContainsKey(letter))
                {
                    letters[letter] = new Int32();
                }
                letters[letter] += 1;
            }

            foreach (var letter in letters)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}
