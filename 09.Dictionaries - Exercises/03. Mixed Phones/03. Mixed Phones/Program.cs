using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Mixed_Phones
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new SortedDictionary<string, long>();
            var line = Console.ReadLine();
            while (line != "Over")
            {
                //first variant
                //var tokens = line.Split();
                //var firstElement = tokens[0];
                //var lastElement = tokens[tokens.Length - 1];
                // var tokens = line.Split(new char[] { ',', '-', '=' });
                var tokens = line.Split(": ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries); // SUSHTOTO KATO GORE 
                var firstElement = tokens[0];
                var secondElement = tokens[1];
                long phoneNumber = 0;
                if (long.TryParse(firstElement, out phoneNumber))
                {
                    phoneBook[secondElement] = phoneNumber;
                }
                else if(long.TryParse(secondElement, out phoneNumber))
                {
                    phoneBook[firstElement] = phoneNumber;
                }
                line = Console.ReadLine();
            }

            foreach (var kvp in phoneBook)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
