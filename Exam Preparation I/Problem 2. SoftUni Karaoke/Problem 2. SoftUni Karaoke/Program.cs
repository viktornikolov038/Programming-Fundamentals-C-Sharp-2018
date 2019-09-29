using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.SoftUni_Karaoke
{
    class Program
    {
        public static void Main()
        {
            var awards = new Dictionary<string, SortedSet<string>>();
            var participants = Console.ReadLine().Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries);
            var avaivableSongs = Console.ReadLine().Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries);
            while (true)
            {
                var performance = Console.ReadLine();
                if (performance == "dawn")
                {
                    break;
                }
                var performanceProps = performance.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                var currentParticipant = performanceProps[0];
                var currentSong = performanceProps[1];
                var currentAward = performanceProps[2];
                foreach (var participant in participants)
                {
                    if (currentParticipant == participant)
                    {
                        foreach (var song in avaivableSongs)
                        {
                            if (currentSong == song)
                            {
                                if (!awards.ContainsKey(participant))
                                {
                                    awards[participant] = new SortedSet<string>();

                                }
                                awards[participant].Add(currentAward);
                            }
                        }
                    }
                }
            }

            awards = awards
                .OrderByDescending(a => a.Value.Count)
                .ThenBy(a => a.Key)
                .ToDictionary(a => a.Key, a => a.Value);
            if (awards.Count > 0)
            {
                foreach (var participant in awards)
                {
                    Console.WriteLine($"{participant.Key}: {participant.Value.Count} awards");
                    foreach (var award in participant.Value)
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
