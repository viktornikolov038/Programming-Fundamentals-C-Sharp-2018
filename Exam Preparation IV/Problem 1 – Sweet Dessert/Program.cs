using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1___Sweet_Dessert
{
    class Program
    {
        public static void Main()
        {
            var cash = decimal.Parse(Console.ReadLine());
            var guests = long.Parse(Console.ReadLine());
            var bananaPrice = decimal.Parse(Console.ReadLine());
            var eggPrice = decimal.Parse(Console.ReadLine());
            var berriesPrice = decimal.Parse(Console.ReadLine());

            var portions = Math.Ceiling(guests / 6.0m);

            var neededMoney = portions * (2 * bananaPrice) + portions * (4 * eggPrice) + portions * (0.2m * berriesPrice);
            if (cash >= neededMoney)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {neededMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(neededMoney - cash):f2}lv more.");
            }
        }
    }
}
