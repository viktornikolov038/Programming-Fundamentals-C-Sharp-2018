using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Football_StandingsDone
{
    public class Score
    {
        public int Point { get; set; }

        public int Goals { get; set; }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            var key = Regex.Escape(Console.ReadLine());
            var pattern =
                $@"^.*(?:{key})(?<team1>[a-zA-Z]*)(?:{key}).* .*(?:{key})(?<team2>[a-zA-Z]*)(?:{key}).* (?<team1Goals>\d+):(?<team2Goals>\d+).*$";
            var regex = new Regex(pattern);

            var teamScores = new Dictionary<string, Score>();
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "final")
                {
                    break;
                }
                var match = regex.Match(line);

                if (!match.Success)
                {                  
                    continue;
                }
                var team1Name = new string(match.Groups["team1"].Value.ToUpper().Reverse().ToArray());
                var team2Name = new string(match.Groups["team2"].Value.ToUpper().Reverse().ToArray());
                var team1Goals = int.Parse(match.Groups["team1Goals"].Value);
                var team2Goals = int.Parse(match.Groups["team2Goals"].Value);

                if (!teamScores.ContainsKey(team1Name))
                {
                    teamScores[team1Name] = new Score();
                }

                if (!teamScores.ContainsKey(team2Name))
                {
                    teamScores[team2Name] = new Score();
                }

                //win 3 points
                //tie 1 point each
                //lose 0 points
                if (team1Goals > team2Goals)//team 1 wins
                {
                    teamScores[team1Name].Point += 3;
                }
                else if (team1Goals == team2Goals)// tie
                {
                    teamScores[team1Name].Point += 1;
                    teamScores[team2Name].Point += 1;
                }
                else//team 2 wins
                {
                    teamScores[team2Name].Point += 3;
                }

                teamScores[team1Name].Goals += team1Goals;
                teamScores[team2Name].Goals += team2Goals; 
            }

            teamScores = teamScores
                .OrderByDescending(a => a.Value.Point)
                .ThenBy(a => a.Key)
                .ToDictionary(a => a.Key, a => a.Value);
            

            Console.WriteLine("League standings:");
            var counter = 1;
            foreach (var teamScore in teamScores)
            {
                
                Console.WriteLine(counter +". "+  teamScore.Key + " " + teamScore.Value.Point);
                counter++;
            }
            var teamScoresByGoals = teamScores
                .OrderByDescending(a => a.Value.Goals)
                .ThenBy(a => a.Key)
                .Take(3)
                .ToDictionary(a => a.Key, a => a.Value);
            Console.WriteLine("Top 3 scored goals:");
            foreach (var teamScore in teamScoresByGoals)
            {
                

                Console.WriteLine($"- {teamScore.Key} -> {teamScore.Value.Goals}");
               
            }
        }
    }
}
