using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3.Football_Standings
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine();

            while (true)
            {
                var currentLine = Console.ReadLine();
                var tokens = currentLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (currentLine == "final")
                {
                    break;
                }


                var pattern = $@"{key}\w+{key}";
                var regex = new Regex(pattern);

                var matches = regex.Matches(currentLine);
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Value);
                }
            }
        }
    }
}
