using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLastSingle
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>
            {
                1,2,3,4,5,6,7,8,9
            };
            Console.WriteLine(numbers.OrderByDescending(n => n).First());
            Console.WriteLine(numbers.Last());
            var firstOdd = numbers.Last(n => n % 2 == 0);
            Console.WriteLine(firstOdd);
            Console.WriteLine(numbers.FirstOrDefault(n => n > 1000));
        }
    }
}
