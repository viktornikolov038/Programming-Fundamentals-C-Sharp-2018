using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3___Wormhole
{
    class Program
    {
        public static void Main()
        {
            var holes = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var steps = 0;
            for (int i = 0; i < holes.Length; i++)
            {
                if (holes[i] == 0)
                {
                    steps++;
                    continue;
                    
                }
                else
                {
                    var currentIndex = i;
                    i = holes[i];
                    holes[currentIndex] = 0;
                    steps++;
                }

            }
            Console.WriteLine(steps);
        }
        
    }
}
