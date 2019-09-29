using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4___Worms_World_Party
{
    class Program
    {
        public static void Main()
        {

            var allWorms = new List<string>();
            var data = new Dictionary<string, Dictionary<string, long>>();
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "quit")
                {
                    break;
                }
                var inputParams = inputLine.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                var wormName = inputParams[0].Trim();
                var teamName = inputParams[1].Trim();
                var wormScore = long.Parse(inputParams[2].Trim());

                if (!allWorms.Contains(wormName))
                {
                    if (!data.ContainsKey(teamName))
                    {
                        data[teamName] = new Dictionary<string, long>();
                    }
                    if (!data[teamName].ContainsKey(wormName))
                    {
                        data[teamName][wormName] = wormScore;
                    }
                }
                allWorms.Add(wormName);
            }
            data = data.OrderByDescending(w => w.Value.Values.Sum())
               .ThenByDescending(w => w.Value.Values.Average())
               .ToDictionary(w => w.Key, w => w.Value.ToDictionary(y => y.Key, y => y.Value));

            var count = 1;

            foreach (var team in data)
            {

                Console.WriteLine("{0}. Team: {1} - {2}", count, team.Key, team.Value.Values.Sum());
                count++;
                foreach (var warm in team.Value.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value))
                {
                    Console.WriteLine("###{0} : {1}", warm.Key, warm.Value);
                }
            }

        }
    }
}
