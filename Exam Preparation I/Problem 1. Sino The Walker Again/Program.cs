using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Sino_The_Walker_Again
{
    class Program
    {
        public static void Main()
        {
            var format = @"hh\:mm\:ss";
            var leavingTime = TimeSpan.ParseExact(Console.ReadLine(), format, CultureInfo.CurrentCulture);
            var steps = long.Parse(Console.ReadLine());
            var timeForStep = long.Parse(Console.ReadLine());
            var secondInDay = 24 * 60 * 60;
            var walkingTime = (int)((steps * timeForStep) % secondInDay);
            leavingTime = leavingTime.Add(new TimeSpan(0, 0, 0, walkingTime));
            Console.WriteLine($"Time Arrival: {leavingTime.ToString(format)}");
        }
    }
}
