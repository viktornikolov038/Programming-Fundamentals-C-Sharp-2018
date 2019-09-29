using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusVideo
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine(GetMultipleOfEvensAndOdds(12341234));
        }
        public static int GetMultipleOfEvensAndOdds(int number)
        {
            var result = 0;
            foreach (var symbol in number.ToString())
            {
                //var result = '9' - '0'
                //9 = 109
                //0 = 100
                //result = 9
                var digit = symbol - '0';
                Console.WriteLine(digit);
            }
            return result;
        }
    }
}
