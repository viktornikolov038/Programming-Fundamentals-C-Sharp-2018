using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.SoftUni_Karaoke_Vol._3
{
    class Program
    {
        public static void Main()
        {
            var participants = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            var songs = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            var awards = new Dictionary<string, SortedSet<string>>();

            while (true)
            {
                var command = Console.ReadLine();
                if (command == "dawn")
                {
                    break;
                }
                var commandParams = command
                    .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                var currentParticipant = commandParams[0];
                var currentSong = commandParams[1];
                var currentAward = commandParams[2];

                foreach (var participant in participants)
                {
                    foreach (var song in songs)
                    {
                        if (currentParticipant == participant && currentSong == song)
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

            awards = awards
                .OrderByDescending(a => a.Value.Count)
                .ThenBy(a => a.Key)
                .ToDictionary(a => a.Key, a => a.Value);
                

            if (awards.Any())
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
