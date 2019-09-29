using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HelpMe
{
    class Program
    {
        public static void Main(string[] args)
        {
            string token = Console.ReadLine();
            var regex2 = new Regex(@"\d+$");
            var match2 = regex2.Match(token);
            Console.WriteLine(match2);
        }
    }
}
