using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___weet_Dessert
{
    class Program
    {
        public static void Main()
        {
            var amountOfCash = double.Parse(Console.ReadLine());
            var guest = int.Parse(Console.ReadLine());
            var bananaPrice = double.Parse(Console.ReadLine());
            var eggPrice = double.Parse(Console.ReadLine());
            var berriesPriceKilo = double.Parse(Console.ReadLine());
            int sets = (int)Math.Ceiling(guest / 6.0);
            var priceForOneSet = 2 * bananaPrice + 4 * eggPrice + berriesPriceKilo * 0.2;
            var totalPrice = priceForOneSet * sets;
            if (totalPrice <= amountOfCash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(totalPrice - amountOfCash):f2}lv more.");
            }
        }
    }
}
