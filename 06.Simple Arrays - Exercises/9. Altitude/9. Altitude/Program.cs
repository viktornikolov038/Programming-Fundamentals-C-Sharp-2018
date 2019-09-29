using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Altitude
{
    class Program
    {
        public static void Main()
        {
            var commands = Console.ReadLine().Split();
            var startinPoint = long.Parse(commands[0]);
            for (int i = 1; i < commands.Length - 1; i+=2)
            {
                if (commands[i] == "up")
                {
                    startinPoint += long.Parse(commands[i + 1]);
                }
                else
                {
                    startinPoint -= long.Parse(commands[i + 1]);
                }
                if (startinPoint <= 0)
                {
                    Console.WriteLine("crashed");
                    return;
                }
            }
            Console.WriteLine("got through safely. current altitude: {0}m",startinPoint);


        }
    }
}
