using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3___Endurance_Rally
{
    class Program
    {
        public static void Main()
        {
            var participants = Console.ReadLine().Split(' ');
            var track = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            var checkpoints = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            foreach (var participant in participants)
            {
                var fuel = (double)participant[0];
                for (int i = 0; i < track.Length; i++)
                {
                    for (int r = 0; r < checkpoints.Length; r++)
                    {
                        if (i == checkpoints[r])
                        {
                            fuel += track[i];
                            fuel += track[i];

                            break;
                        }

                    }
                    fuel -= track[i];
                    if (fuel <= 0)
                    {
                        Console.WriteLine($"{participant} - reached {i}");
                        break;
                    }
                }
                if (fuel > 0)
                {
                    Console.WriteLine($"{participant} - fuel left {fuel:f2}");
                }
                
            }
        }
    }
}
