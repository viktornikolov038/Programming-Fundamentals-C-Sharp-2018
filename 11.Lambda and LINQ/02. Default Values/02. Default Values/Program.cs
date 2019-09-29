using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Default_Values
{
    class Program
    {
        public static void Main()
        {
            var dictionary = new Dictionary<string, string>();
            var input = Console.ReadLine();

            while (input != "end")
            {
                var tokens = input.Split(new[] { ' ', '-', '>', },StringSplitOptions.RemoveEmptyEntries);
                var key = tokens[0];
                var value = tokens[1];
                dictionary[key] = value;

                input = Console.ReadLine();
            }
            var defaultValue = Console.ReadLine();

            var unchangedValues = dictionary
                .Where(n => n.Value != "null")
                .OrderByDescending(n => n.Value.Length)
                .ToDictionary(n => n.Key, n => n.Value);

            var changedValues = dictionary
                .Where(n => n.Value == "null")
                .ToDictionary(n => n.Key, n => defaultValue);

            foreach (var entry in unchangedValues)
            {
                Console.WriteLine("{1} <-> {0}",entry.Value,entry.Key);
            }
            foreach (var entry in changedValues)
            {
                Console.WriteLine("{1} <-> {0}", entry.Value, entry.Key);
            }

        }
    }
}
