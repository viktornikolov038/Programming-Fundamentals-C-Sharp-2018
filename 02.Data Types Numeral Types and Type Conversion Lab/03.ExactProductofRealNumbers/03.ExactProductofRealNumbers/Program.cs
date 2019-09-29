using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal result = 1M;
            for (int i = 0; i < n; i++)
            {
                decimal entered = decimal.Parse(Console.ReadLine());
                result = result * entered;
            }
            Console.WriteLine(result);
        }
    }
}
