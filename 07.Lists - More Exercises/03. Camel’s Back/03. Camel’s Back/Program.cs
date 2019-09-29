using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Camel_s_Back
{
    class Program
    {
        static void Main(string[] args)
        {
            var beggining = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var camelBack = int.Parse(Console.ReadLine());
            var roundsCounter = 0;
            for (int i = 0; i < beggining.Count; i++)
            {

                if (beggining.Count == camelBack)
                {
                    break;
                }
                else
                {
                    beggining.RemoveAt(0);
                    beggining.RemoveAt(beggining.Count - 1);

                }
                roundsCounter++;
            }
            var remaining = string.Join(" ", beggining);
            if (roundsCounter > 0)
            {
                Console.WriteLine($"{roundsCounter} rounds");
                Console.WriteLine($"remaining: {remaining}");
            }
            else
            {
                Console.WriteLine($"already stable: {remaining}");
            }

        }
    }
}
