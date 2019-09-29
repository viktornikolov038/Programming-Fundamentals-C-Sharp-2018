using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hornet_Wings
{
    class Program
    {
        public static void Main()
        {
            var wingFlats = int.Parse(Console.ReadLine());
            var distanceFor1000Flaps = double.Parse(Console.ReadLine());
            var endurance = int.Parse(Console.ReadLine());

            var distanceInMeters = (wingFlats / 1000) * distanceFor1000Flaps;
            double seconds = wingFlats / 100.0;
            double rest = (wingFlats / endurance) * 5;
            double secondAtAll = seconds + rest;
            Console.WriteLine($"{distanceInMeters:f2} m.");
            Console.WriteLine($"{secondAtAll} s.");

        }
    }
}
