using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Endurance_Rally
{
    class Program
    {
        public static void Main()
        {
            var driversNames = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var zones = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToList();
            var checkpointIndexes = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();

            var fuel = 0.0M;

            foreach (var driver in driversNames)
            {
                fuel = (decimal)driver[0];
                for (int i = 0; i < zones.Count; i++)
                {
                    for (int j = 0; j < checkpointIndexes.Count; j++)
                    {
                        if (i == checkpointIndexes[j])
                        {
                            fuel += zones[i];
                            fuel += zones[i];
                            break;
                        }
                    }
                    fuel -= zones[i];
                    if (fuel <= 0)
                    {
                        Console.WriteLine($"{driver} - reached {i}");
                        break;
                    }
               }

                if (fuel > 0)
                {
                    Console.WriteLine($"{driver} - fuel left {fuel:F2}");
                }

            }



        }
    }
}
