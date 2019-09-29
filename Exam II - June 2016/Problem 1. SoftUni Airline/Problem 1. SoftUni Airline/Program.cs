using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.SoftUni_Airline
{
    class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var totalProfit = 0.0M;

            for (int i = 0; i < n; i++)
            {
                var adultPassengersCount = long.Parse(Console.ReadLine());
                var adultTickedPrice = decimal.Parse(Console.ReadLine());
                var youthPassengersCount = long.Parse(Console.ReadLine());
                var youthTickedPrice = decimal.Parse(Console.ReadLine());
                var fuelPricePerHour = decimal.Parse(Console.ReadLine());
                var fuelConsumationPerHours = decimal.Parse(Console.ReadLine());
                var flightDuration = long.Parse(Console.ReadLine());
                var ticketsIncome = (adultPassengersCount * adultTickedPrice) + (youthPassengersCount * youthTickedPrice);
                var flightExpenses = flightDuration * fuelConsumationPerHours * fuelPricePerHour;

                var profit = ticketsIncome - flightExpenses;

                
                if (profit >= 0)
                {
                    Console.WriteLine($"You are ahead with {profit:F3}$.");
                }
                else
                {
                    Console.WriteLine($"We've got to sell more tickets! We've lost {profit:F3}$.");
                }

                totalProfit += profit;

            }

            Console.WriteLine($"Overall profit -> {totalProfit:f3}$.");
            Console.WriteLine($"Average profit -> {totalProfit/n:f3}$.");
        }
    }
}
