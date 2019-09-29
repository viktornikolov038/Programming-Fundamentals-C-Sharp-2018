using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Happiness_Index
{
    class Program
    {
        public static void Main(string[] args)
        {
            var inputEmoji = Console.ReadLine();
            var happyPattern = @"(?:([:;(\[*c])([D\)\*\]\}:;]))";
            var happyRegex = new Regex(happyPattern);
            var sadPattern = @"(?:([:;D)\]])([\(\[\{c:;]))";
            var sadRegex = new Regex(sadPattern);

            var happyMatch = happyRegex.Matches(inputEmoji);
            var sadMatch = sadRegex.Matches(inputEmoji);


            var happyClean = "";

            foreach (Match emoji in happyMatch)
            {
                var currentEmoji = (string)emoji.Value;
                if (currentEmoji[0] == currentEmoji[1])
                {
                    continue;
                }
                happyClean += emoji.Value + " ";

            }

            var kur = happyClean.TrimEnd().Split(' ');

            var happyMatchClean = happyRegex.Matches(happyPattern);

            double happyIndex = (double)kur.Length / (double)sadMatch.Count;
            var emojiResult = HappinesEmoji(happyIndex);

            Console.WriteLine("Happiness index: {0:F2} {1}", happyIndex, emojiResult);
            Console.WriteLine("[Happy count: {0}, Sad count: {1}]", kur.Length, sadMatch.Count);
        }
        public static string HappinesEmoji(double happyIndex)
        {
            if (happyIndex >= 2)
            {
                return ":D";
            }
            else if (happyIndex > 1)
            {
                return ":)";
            }
            else if (happyIndex == 1)
            {
                return ":|";
            }
            else
            {
                return ":(";
            }
        }
    }
}
