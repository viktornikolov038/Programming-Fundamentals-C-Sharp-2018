using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1___Hornet_Wings
{
    class Program
    {
        public static void Main()
        {
            var wingFlaps = long.Parse(Console.ReadLine());
            var distanceFor1000flaps = double.Parse(Console.ReadLine());
            var endurance = long.Parse(Console.ReadLine());
            var flaptsPerSec = 100;

            double distance = (wingFlaps / 1000.0) * distanceFor1000flaps;
            var flyTime = wingFlaps / flaptsPerSec;
            var restTime = (wingFlaps / endurance) * 5;

            var seconds = flyTime + restTime;
            Console.WriteLine($"{distance:F2} m.");
            Console.WriteLine($"{seconds} s.");

        }
    }
}
