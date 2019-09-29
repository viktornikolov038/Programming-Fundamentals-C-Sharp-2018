using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal Proxima = 4.22M;
            decimal Center = 26000M;
            decimal Diameter = 100000M;
            decimal End = 46500000000M;
            decimal lightInKm = 9450000000000;
            Console.WriteLine("{0:e2}",Proxima * lightInKm);
            Console.WriteLine("{0:e2}", Center * lightInKm);
            Console.WriteLine("{0:e2}", Diameter * lightInKm);
            Console.WriteLine("{0:e2}", End * lightInKm);

        }
    }
}
