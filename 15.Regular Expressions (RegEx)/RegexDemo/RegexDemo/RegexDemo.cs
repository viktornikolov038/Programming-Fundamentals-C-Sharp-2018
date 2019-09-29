using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    public class Program
    {
        public static void Main()
        {
            var pattern = @"(\d{4})-(\d{2}|\w{3})-(\d{2})";
            var regex = new Regex(pattern);

            var text = "Today is 2017-01-04, Tommorow is 2017-Jan-04";
            var text2 = "Tommorow is 2017-Jan-04";

            var isMatch = regex.Matches(text);

            foreach (Match match in isMatch)
            {
                Console.WriteLine(match.Groups[2]);
            }
        }
    }
}
