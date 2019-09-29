using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sales_Report
{
    class Program
    {
        public static void Main()
        {
            var total = int.Parse(Console.ReadLine());

            var result = new SortedDictionary<string, decimal>();

            for (int i = 0; i < total; i++)
            {
                var currentSaleAsString = Console.ReadLine();
                //var currentSale = ReadSale();
                var currentSale = Sale.Parse(currentSaleAsString);

                if (!result.ContainsKey(currentSale.Town))
                {
                    result[currentSale.Town] = 0;
                }

                result[currentSale.Town] += currentSale.Quantity * currentSale.Price;
            }

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key:f2} -> {kvp.Value:f2}");

            }
        }


        //Moje i po tozi nachin moje i prez samiqt class  Sale.cs chez Parse
        //public static Sale ReadSale()
        //{
        //    var saleProps = Console.ReadLine()
        //        .Split(' ')
        //        .ToArray();
        //    return new Sale()
        //    {
        //        Town = saleProps[0],
        //        Product = saleProps[1],
        //        Price = decimal.Parse(saleProps[2]),
        //        Quantity = decimal.Parse(saleProps[3])
        //    };
        //}
    }
}
