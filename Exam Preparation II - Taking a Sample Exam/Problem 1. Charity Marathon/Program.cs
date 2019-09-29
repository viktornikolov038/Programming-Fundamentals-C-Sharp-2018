using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            var marathonDays = long.Parse(Console.ReadLine());
            var runners = long.Parse(Console.ReadLine());
            var avgNumOfLaps = long.Parse(Console.ReadLine());
            var trackLenght = long.Parse(Console.ReadLine());
            var trackCapacity = long.Parse(Console.ReadLine());
            var moneyPerKm = double.Parse(Console.ReadLine());

            var maximumRunners = marathonDays * trackCapacity;
            long willRun = 0;
            if (maximumRunners < runners)
            {
                willRun = maximumRunners;
            }
            else
            {
                willRun = runners;
            }
            var totalMeters = willRun * avgNumOfLaps * trackLenght;
            var totalKm = totalMeters / 1000;
            var moneyRaised = totalKm * moneyPerKm;
            Console.WriteLine($"Money raised: {moneyRaised:F2}");
        }
    }
}
