using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sino_The_Walker
{
    class Program
    {
        public static void Main()
        {
            var timeFormat = @"hh\:mm\:ss";
            var startingTime = TimeSpan.ParseExact(Console.ReadLine(), timeFormat, CultureInfo.CurrentCulture);

            var steps = int.Parse(Console.ReadLine());
            var secForStep = int.Parse(Console.ReadLine());

            var secondIndDay = 60 * 60 * 24;
            var totalSecondNeeded = (int)(((double)secForStep * steps) % secondIndDay);

            var arrivalTime = startingTime.Add(new TimeSpan(0, 0, totalSecondNeeded));

            Console.WriteLine("Time Arrival: " + arrivalTime.ToString(timeFormat));
        }
    }
}
    