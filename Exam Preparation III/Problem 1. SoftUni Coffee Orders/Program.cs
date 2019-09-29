using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.SoftUni_Coffee_Orders
{
    class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var timeFormat = "d/M/yyyy";
            var totalPrice = 0M;
            for (int i = 0; i < n; i++)
            {
                var pricePerCapluse = decimal.Parse(Console.ReadLine());
                var orderDate = DateTime.ParseExact(Console.ReadLine(), timeFormat, CultureInfo.CurrentCulture);
                var capsulesCount = int.Parse(Console.ReadLine());

                var daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                var price = (daysInMonth * (long)capsulesCount) * pricePerCapluse;
                Console.WriteLine($"The price for the coffee is: ${price:F2}");
                totalPrice += price;
            }
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
