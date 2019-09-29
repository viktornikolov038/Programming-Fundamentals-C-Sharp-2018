using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split()
                .ToArray();
            var rnd = new Random();
            
            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];
                var randomPosition = rnd.Next(0, words.Length);
                var temporary = words[randomPosition];
                words[randomPosition] = currentWord;
                words[i] = temporary;
               
            }
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
