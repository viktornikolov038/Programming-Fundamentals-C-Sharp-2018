using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shellbound
{
    class Shellbound
    {
        public static void Main()
        {
            var shellsAndRegions = new Dictionary<string, HashSet<int>>();
            var line = Console.ReadLine();

            while (line != "Aggregate")
            {
                var tokens = line.Split();
                var regions = tokens[0];
                var shell = int.Parse(tokens[1]);

                if (!shellsAndRegions.ContainsKey(regions))
                {
                    shellsAndRegions[regions] = new HashSet<int>();
                }
                shellsAndRegions[regions].Add(shell);

                line = Console.ReadLine();
            }

            foreach (var region in shellsAndRegions)
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

                Console.WriteLine("{0} -> {1} ({2})", region.Key, string.Join(", ", region.Value), sum);
            }

            ////var line = Console.ReadLine();
            //while (line != "Kit")
            //{
            //    Console.WriteLine(line);
            //    line = Console.ReadLine();
            //}
        }


    }
}
