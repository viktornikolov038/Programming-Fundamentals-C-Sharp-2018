using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ShootLisrElem2
{
    class MineProgram
    {
        public static void Main()
        {
            var input = new List<int>();

            var inputLine = Console.ReadLine();

            var lastNum = 0;

            while (inputLine != "stop")
            {
                if (inputLine == "bang" && input.Count == 0)
                {
                    Console.WriteLine("nobody left to shoot! last one was {0}", lastNum);
                    return;
                }

                if (inputLine != "bang")
                {
                    input.Insert(0, int.Parse(inputLine));
                }

                if (inputLine == "bang")
                {
                    var avarageSum = input.Average();

                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] <= avarageSum)
                        {
                            lastNum = input[i];
                            input.RemoveAt(i);
                            Console.WriteLine("shot {0}", lastNum);
                            break;
                        }
                    }
                    Decrement(input);

                }
                inputLine = Console.ReadLine();
            }
            if (inputLine == "stop" && input.Count > 0)
            {
                Console.WriteLine($"survivors: {string.Join(" ", input)}");
            }
            if (inputLine == "stop" && input.Count == 0)
            {
                Console.WriteLine($"you shot them all. last one was {lastNum}");
            }
        }

        public static void Decrement(List<int> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                input[i]--;
            }
        }
    }
}
