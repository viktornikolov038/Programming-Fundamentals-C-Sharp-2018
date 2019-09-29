using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2___Worm_Ipsum
{
    class Program
    {
        public static void Main()
        {
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "Worm Ipsum")
                {
                    break;
                }
                if (line[line.Length - 1] != '.')
                {
                    continue;
                }
                if (!char.IsUpper(line[0]))
                {
                    continue;
                }
                var inputparams = line.Split('.');

                if (inputparams.Length > 2)
                {
                    continue;
                }

                var sentance = inputparams[0];
                var wordInSentance = sentance.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var currentSentance = new StringBuilder();
                foreach (var word in wordInSentance)
                {
                    if (word.Distinct().Count() == word.Length)
                    {
                        currentSentance.Append($"{word} ");
                    }
                    else
                    {
                        var mostRepeated = word.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
                        var doneString = string.Empty;
                        for (int i = 0; i < word.Length; i++)
                        {
                            doneString += mostRepeated;
                        }
                        currentSentance.Append(doneString + " ");
                    }
                }
                Console.Write(currentSentance.ToString().TrimEnd());
                Console.WriteLine(".");
            }


        }
    }
}
