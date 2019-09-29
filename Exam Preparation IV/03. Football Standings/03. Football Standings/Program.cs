using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Football_Standings
{
    class Program
    {
        public static void Main()
        {
            var inputKey = Console.ReadLine();
            var key = "";
            var result = new SortedDictionary<string, string>();
            foreach (var symbol in inputKey)
            {
                key += "\\" + symbol;
            }
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "final")
                {
                    break;
                }
                var pattern = key + @"\w+" + key;

     
                var regex = new Regex(pattern);
                var matches = regex.Matches(input);

                var currentTeams = new List<string>();

                foreach (Match team in matches)
                {
                    currentTeams.Add(team.Value.ToString());
                }

                foreach (var team in currentTeams)
                {
                    var pattern2 = key;
                    var secondRegex = new Regex(pattern2);
                    var reversedTeam =  Reverse(team);
                    var teamFinal = secondRegex.Replace(reversedTeam,string.Empty).ToUpper();
                    Console.WriteLine(teamFinal);
                }

            }
        }

        private static string Reverse(string team)
        {
            char[] Carray = team.ToCharArray();
            string reverse = string.Empty;
            for (int i = Carray.Length - 1; i >= 0; i--)
            {
                reverse += Carray[i];
            }
            return reverse;
        }
    }
}
