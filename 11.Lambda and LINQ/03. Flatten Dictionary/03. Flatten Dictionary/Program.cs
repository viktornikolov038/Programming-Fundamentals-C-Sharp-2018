using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Flatten_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, Dictionary<string, string>>();
            var line = Console.ReadLine();

            while (line != "end")
            {            
                var tokens = line.Split(' ');
                if (tokens[0] != "flatten")
                {

                    var key = tokens[0];
                    var innerKey = tokens[1];
                    var innerValue = tokens[2];
                    if (!dictionary.ContainsKey(key))
                    {
                        dictionary[key] = new Dictionary<string, string>();
                    }
                    if (!dictionary[key].ContainsKey(innerKey))
                    {
                        dictionary[key][innerKey] = innerValue;
                    }
                }
                else
                {
                    var key = tokens[1];
                }
                line = Console.ReadLine();

            }

            foreach (var kvp in dictionary)
            {
                var firstKey = kvp.Key;
                var secondKey = kvp.Value;
                Console.WriteLine(firstKey);
                var counter = 1;
                foreach (var item in secondKey)
                {
                    Console.WriteLine(counter + ". " + item.Key + " " + item.Value);
                    counter++;

                }
               
            }
        }
    }
}
