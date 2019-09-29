using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1.SoftUni_Coffee_Orders
{
    class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var dateFormat = "d/M/yyyy";
            decimal totalPrice = 0.0M;
            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                var date = DateTime.ParseExact(Console.ReadLine(), dateFormat, CultureInfo.CurrentCulture);
                var capsuleCount = int.Parse(Console.ReadLine());
                var daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
                decimal price = (daysInMonth * (long)capsuleCount) *pricePerCapsule;
                Console.WriteLine("The price for the coffee is: ${0:F2}",price);
                totalPrice += price;
            }
            Console.WriteLine("Total: ${0:F2}",totalPrice);
        }
    }
}
