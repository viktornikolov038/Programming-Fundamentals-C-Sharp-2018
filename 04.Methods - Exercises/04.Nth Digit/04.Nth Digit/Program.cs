using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Nth_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine(FindNthDigit(number,index));
        }
        public static int FindNthDigit(long number,int index)
        {
            int counter = 1;
            while (number > 0)
            {
                if (counter == index)
                {
                    return (int)number % 10;
                }
                counter++;
                number /= 10;
            }
            return 0;
        }
    }
}
