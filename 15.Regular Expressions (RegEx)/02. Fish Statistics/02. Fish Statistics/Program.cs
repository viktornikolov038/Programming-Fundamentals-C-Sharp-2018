using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Fish_Statistics
{
    class Program
    {
        public static void Main()
        {
            var inputFish = Console.ReadLine();
            var pattern = @"(>*)<(\(+)(['\-x])>";
            var regex = new Regex(pattern);
            var matchFishes = regex.Matches(inputFish);
            var counterOfFishes = 1;
            foreach (Match fish in matchFishes)
            {
                Console.WriteLine($"Fish {counterOfFishes}: " + fish.Value);
                TailLenght(fish);
                BodyLenght(fish);
                Status(fish);
                counterOfFishes++;
            }

            var areThereFishes = regex.Match(inputFish);
            if (!areThereFishes.Success)
            {
                Console.WriteLine("No fish found.");
            }

        }

        private static void BodyLenght(Match fish)
        {
            var bodyLenght = (int)(fish.Groups[2].Value.Length);
            if (bodyLenght > 10)
            {
                Console.WriteLine("  Body type: Long ({0} cm)", bodyLenght * 2);

            }
            else if (bodyLenght > 5)
            {
                Console.WriteLine("  Body type: Medium ({0} cm)", bodyLenght * 2);
            }
            else
            {
                Console.WriteLine("  Body type: Short ({0} cm)", bodyLenght * 2);
            }
        }

        private static void TailLenght(Match fish)
        {
            var tailLenght = (int)(fish.Groups[1].Value.Length);
            if (tailLenght > 5)
            {
                Console.WriteLine("  Tail type: Long ({0} cm)", tailLenght * 2);
            }
            else if (tailLenght > 1)
            {
                Console.WriteLine("  Tail type: Medium ({0} cm)", tailLenght * 2);

            }
            else if (tailLenght == 1)
            {
                Console.WriteLine("  Tail type: Short ({0} cm)", tailLenght * 2);

            }
            else
            {
                Console.WriteLine("  Tail type: None");
            }
        }

        private static void Status(Match fish)
        {
            var status = fish.Groups[3].Value;
            if (status == "'")
            {
                Console.WriteLine("  Status: Awake");
            }
            else if (status == "-")
            {
                Console.WriteLine("  Status: Asleep");
            }
            else
            {
                Console.WriteLine("  Status: Dead");
            }
        }
    }
}
