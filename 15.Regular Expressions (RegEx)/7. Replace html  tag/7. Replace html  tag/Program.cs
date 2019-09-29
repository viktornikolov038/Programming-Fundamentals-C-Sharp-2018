using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _7.Replace_html__tag
{
    public class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine();

            var pattern = "<ahref=(.+?)>(.+?)<\\/a>";
            var regex = new Regex(pattern);

            var match = regex.IsMatch(pattern);
            Console.WriteLine(match);


        }
    }
}
