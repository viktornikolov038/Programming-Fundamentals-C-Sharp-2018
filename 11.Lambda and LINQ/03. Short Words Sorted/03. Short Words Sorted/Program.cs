using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower().Split(new[] {'.',',', ':', ';', '(', ')', '[', ']', '"', '\'','\\', '/', '!', '?',' '},StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var result = text
                .Where(n => n.Length < 5)
                .OrderBy(n => n)
                //.Select(n => n.ToLower())
                .Distinct()
                .ToList();
            Console.WriteLine(string.Join(", ",result));
   
        }
    }
}
