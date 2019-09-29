using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_1___Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            var pattern = Console.ReadLine();
            var regex = new Regex($@"{pattern}");
           
            var replace =  regex.Replace(inputLine, "");
            Console.WriteLine(replace);
        }
    }
}
