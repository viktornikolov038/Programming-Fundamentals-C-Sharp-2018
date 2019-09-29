using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shellbound
{
    class Program
    {
        public static void Main()
        {
            var result = new Dictionary<string, HashSet<int>>();
            while (true)
            {

                var inputLine = Console.ReadLine();
                if (inputLine == "Aggregate")
                {
                    break;
                }
                var inputParams = inputLine.Split();
                var currentTown = inputParams[0];
                var currentShell = int.Parse(inputParams[1]);
                if (!result.ContainsKey(currentTown))
                {
                    result[currentTown] = new HashSet<int>();
                }
                result[currentTown].Add(currentShell);

            }
            foreach (var region in result)
            {
                long sum = 0L;
                foreach (var shell in region.Value)
                {
                    sum += shell;

                }
                if (region.Value.Count > 1)
                {
                    sum -= sum / region.Value.Count;
                }
                Console.WriteLine($"{region.Key} -> {string.Join(", ",region.Value)} ({sum})");
            }
        }
    }
}
