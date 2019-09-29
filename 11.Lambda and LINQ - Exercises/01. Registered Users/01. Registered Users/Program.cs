using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Registered_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            var regiseterUsernames = new Dictionary<string, DateTime>();
            var nameAndDate = Console.ReadLine();
            while (nameAndDate != "end")
            {
                var tokens = nameAndDate.Split(new[] { ' ', '-', '>' },StringSplitOptions.RemoveEmptyEntries);
                var userName = tokens[0];
                var date = DateTime.ParseExact(tokens[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                regiseterUsernames[userName] = date;
                nameAndDate = Console.ReadLine();
            }
            var result = regiseterUsernames
                .Reverse()
                .OrderBy(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value)
                .Take(5)
                .OrderByDescending(x => x.Value);                
            foreach (var kvp in result)
            {
                Console.WriteLine(kvp.Key);
            }
        }
    }
}
