using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_3___Rage_Quit
{
    class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"\D+\d+");
            var regex2 = new Regex(@"\d+");
            var matches = regex.Matches(input);
            var result = new StringBuilder();
            var uniqueSymbols = new HashSet<char>();
            foreach (Match match in matches)
            {
                var currentMatch = match.ToString();
                var number = int.Parse(regex2.Match(match.ToString()).ToString());
                var currentString = match.ToString().Reverse().Skip(number.ToString().Length).ToString();
                for (int i = 0; i < number; i++)
                {
                    result.Append(currentString.ToUpper());
                }
                
            }
            foreach (var symbol in result.ToString())
            {
                uniqueSymbols.Add(symbol);
            }
            Console.WriteLine($"Unique symbols used: {uniqueSymbols.Count}");
            Console.WriteLine(result);
        }
    }
}
