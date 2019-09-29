using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Rage_Quit
{
    class Program
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var regex = new Regex(@"\D+\d+");
            var matchesAsString = new List<string>();
            var matches = regex.Matches(inputLine);
            foreach (Match match in matches)
            {                
                matchesAsString.Add(match.ToString());
            }
            StringBuilder result = new StringBuilder();
            foreach (var match in matchesAsString)
            {
                var regex2 = new Regex(@"\d+$");
                var match2 = regex2.Match(match);    
                var repeatCount = int.Parse(match2.Value.ToString());               
                var ragedString = match.Replace(repeatCount.ToString(),string.Empty);
                var ragedStringUpper = ragedString.ToUpper();
                for (int i = 0; i < repeatCount; i++)
                {
                    result.Append(ragedStringUpper);
                }
            }


            var uniqueSymbols = new HashSet<char>();
            foreach (var symbol in result.ToString())
            {
                uniqueSymbols.Add(symbol);
            }
            Console.WriteLine($"Unique symbols used: {uniqueSymbols.Count}");
            Console.WriteLine(result);
        }
    }
}
