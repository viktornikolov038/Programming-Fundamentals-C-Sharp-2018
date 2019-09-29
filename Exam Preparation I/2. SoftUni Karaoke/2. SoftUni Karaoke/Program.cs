using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.SoftUni_Karaoke
{
    class Program
    {
        public static void Main()
        {
            var participants = Console.ReadLine()
                .Split(new[] { ',',' ' }, StringSplitOptions.RemoveEmptyEntries);
            var avaivableSongs = Console.ReadLine()
                .Split(new[] { ',', }, StringSplitOptions.RemoveEmptyEntries);

            var awards = new Dictionary<string, SortedSet<string>>();

      

            while (true)
            {
                var stagePerformance = Console.ReadLine()
                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
               
                if (stagePerformance[0] == "dawn")
                {
                    break;
                }

                var currentName = stagePerformance[0].Trim();
                var currentSong = stagePerformance[1].Trim();
                var currentAward = stagePerformance[2].Trim();
                foreach (var participant in participants)
                {
                    if (participant == currentName)
                    {
                        foreach (var song in avaivableSongs)
                        {
                            if (currentSong == song.Trim())
                            {
                                if (!awards.ContainsKey(currentName))
                                {
                                    awards[participant] = new SortedSet<string>();
                                }
                                awards[participant].Add(currentAward);
                            }
                            else
                            {
                                
                                continue;
                            }
                        }
                    }
                    else
                    {
                        
                        continue;
                    }
                }
            }

            if (awards.Count == 0)
            {
                Console.WriteLine("No awards");
                return;
            }


            var sortedAwards = awards
                .OrderByDescending(a => a.Value.Count)
                .ThenBy(a => a.Key)
                .ToDictionary(a => a.Key, a => a.Value);

            foreach (var participant in sortedAwards)
            {
                if (participant.Value.Count == 0)
                {
                    Console.WriteLine("No awards");
                }
                else
                {


                    Console.WriteLine(participant.Key + ": " + participant.Value.Count + " awards");
                    foreach (var award in participant.Value)
                    {
                        Console.WriteLine("--" + award);
                    }
                }
            }

        }
    }
}
