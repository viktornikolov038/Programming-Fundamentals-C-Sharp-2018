using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1___Splinter_Trip
{
    class Program
    {
        public static void Main()
        {
            var tripDistanceInMiles = double.Parse(Console.ReadLine());
            var fuelTankCapacity = double.Parse(Console.ReadLine());
            var milesInHeavyWinds = double.Parse(Console.ReadLine());

            var milesInNonHeavyWinds = tripDistanceInMiles - milesInHeavyWinds;
            var nonHeavyConsumption = milesInNonHeavyWinds * 25;
            var heavyWindConsumption = milesInHeavyWinds * (25 * 1.5);

            var fuelConsumption = nonHeavyConsumption + heavyWindConsumption;

            var tolerance = fuelConsumption * 5 / 100;

            var totalFuelConsimpion = fuelConsumption + tolerance;

            Console.WriteLine($"Fuel needed: {totalFuelConsimpion:F2}L");


            if (fuelTankCapacity >= totalFuelConsimpion)
            {
                Console.WriteLine($"Enough with {(fuelTankCapacity - totalFuelConsimpion):f2}L to spare!");
            }
            else
            {
                Console.WriteLine($"We need {Math.Abs(totalFuelConsimpion - fuelTankCapacity):F2}L more fuel.");
            }

        }
    }
}
