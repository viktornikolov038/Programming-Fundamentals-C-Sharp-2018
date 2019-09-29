using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            var capacity = 24.0;
            Console.WriteLine(Math.Ceiling(people/capacity));
        }
    }
}
