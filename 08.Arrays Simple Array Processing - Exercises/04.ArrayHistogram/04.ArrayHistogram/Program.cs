using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ArrayHistogram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            var wordCounter = new List<int>();
            var foundWords = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];

                if (foundWords.Contains(currentWord))
                {
                    int wordIndex = foundWords.IndexOf(currentWord);
                    wordCounter[wordIndex]++;
                }
                else
                {
                    foundWords.Add(currentWord);
                    wordCounter.Add(1);
                }
            }
            bool hasSwapper = true;
            while (hasSwapper)
            {
                hasSwapper = false;
                for (int i = 0; i < wordCounter.Count - 1; i++)
                {
                    
                    if (wordCounter[i] < wordCounter[i + 1])
                    {
                        int temp = wordCounter[i];
                        wordCounter[i] = wordCounter[i + 1];
                        wordCounter[i + 1] = temp;
                        

                        string tempWord = foundWords[i];
                        foundWords[i] = foundWords[i + 1];
                        foundWords[i + 1] = tempWord;

                        hasSwapper = true;
                    }

                }
            }

            for (int i = 0; i < foundWords.Count; i++)
            {
                double currentPercentage = (double)wordCounter[i] / (double)words.Length * 100.0;
                Console.WriteLine("{0} -> {1} times ({2:F2}%)", foundWords[i], wordCounter[i], currentPercentage);
            }
        }
    }
}
