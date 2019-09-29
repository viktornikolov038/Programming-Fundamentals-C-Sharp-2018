using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MultiEvensbyOdds
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var odds = GetOdds(number);
            var evens = GetEvens(number);
            Console.WriteLine(odds * evens);
        }
        
        public static int GetEvens(int number)
        {
            return DigitFinder(number, 1);
        }

        public static int GetOdds(int number)
        {
            return DigitFinder(number, 0);
        }

        public static int DigitFinder(int number, int reminder)
        {
            var result = 0;
            foreach (var symbol in number.ToString())
            {
                var digit = symbol - '0';
                if (digit % 2 == reminder)
                {
                    result += digit;
                }
            }

            return result;
        }
    }
}
