using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Hornet_Assault
{
    class Program
    {
        public static void Main(string[] args)
        {
            var beehives = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();
            var hornets = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();
            var summedPower = hornets.Sum();


            //20 10 20 30 - 5 koshera s pcheli 
            //5 10 5 3 - 4 sturshela s power
            var aliveBeehive = new List<long>();
            foreach (var beesInbeehive in beehives)
            {
                var currentIndex = 0;
                if (beesInbeehive > summedPower)
                {
                    aliveBeehive.Add(beesInbeehive - summedPower);
                    hornets.RemoveAt(0);
                    hornets.Add(0);
                    summedPower = hornets.Sum();
                    beehives.Remove(currentIndex);
                }
                else if (beesInbeehive == summedPower)
                {
                    hornets.RemoveAt(0);
                    hornets.Add(0);
                    summedPower = hornets.Sum();
                    
                }


                if (beehives.Count < 1)
                {
                    break;
                }

                if (hornets.Count < 1)
                {
                    break;
                }
                currentIndex++;
            }

            for (int i = 0; i < hornets.Count; i++)
            {
                if (hornets[i] == 0)
                {
                    hornets.RemoveAt(i);
                }
            }

            if (aliveBeehive.Count > 0)
            {
                Console.WriteLine(string.Join(" ", aliveBeehive));
            }
            else if (hornets.Count > 0)
            {
                Console.WriteLine(string.Join(" ", hornets));
            }

        }
    }
}
