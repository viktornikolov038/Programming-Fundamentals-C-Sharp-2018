using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _01.Cards
{
    class Program
    {
        public static void Main()
        {
            var inputCards = Console.ReadLine();
            var pattern = @"([1]?[0-9AAJQK])([SHDC])";
            Regex regex = new Regex(pattern);
            var matchedCards = regex.Matches(inputCards);

            var validCards = new List<string>();
            foreach (Match card in matchedCards)
            {
                int power = 0;

                if (int.TryParse(card.Groups[1].Value, out power))
                {
                    if (power < 2 || power > 10)
                    {
                        continue;
                    }
                   
                }
                validCards.Add(card.Value);
               
            }
            Console.WriteLine(string.Join(", ", validCards));
        }
    }
}