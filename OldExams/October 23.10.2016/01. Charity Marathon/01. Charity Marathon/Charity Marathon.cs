using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Charity_Marathon
{
    class Program
    {
        public static void Main()
        {
            var marathonDays = int.Parse(Console.ReadLine());
            var numberOfRunners = int.Parse(Console.ReadLine());
            var avgLaps = int.Parse(Console.ReadLine());
            var trackLenght = double.Parse(Console.ReadLine());
            var tracksCapacity = int.Parse(Console.ReadLine());
            var moneyPerKm = double.Parse(Console.ReadLine());
            var maxRunners = marathonDays * tracksCapacity;
            var totalMeters = 0d;
            if (maxRunners <= numberOfRunners)
            {
                totalMeters = maxRunners * avgLaps * trackLenght;
            }
            else
            {
                totalMeters = numberOfRunners * avgLaps * trackLenght;
            }
            var totalKilometers = totalMeters / 1000.0;
            Console.WriteLine("Money raised: {0:f2}",totalKilometers*moneyPerKm);
        }
    }
}
