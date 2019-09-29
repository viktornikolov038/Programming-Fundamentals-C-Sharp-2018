using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.CharityMarathon
{
    class Program
    {
        public static void Main(string[] args)
        {
            var marathonDays = long.Parse(Console.ReadLine());
            var runners = long.Parse(Console.ReadLine());
            var avgNumLaps = long.Parse(Console.ReadLine());
            var trackLenght = long.Parse(Console.ReadLine());
            var trackCapacity = long.Parse(Console.ReadLine());
            var moneyPerKm = decimal.Parse(Console.ReadLine());

            var maxRunners = marathonDays * trackCapacity;
            var willRun = runners;
            if (runners > maxRunners)
            {
                willRun = maxRunners;
            }
            var totalKM = (willRun * avgNumLaps * trackLenght) / 1000M;
            var moneyRaised = totalKM * moneyPerKm;

            Console.WriteLine("Money raised: {0:F2}",moneyRaised);
        }
    }
}
