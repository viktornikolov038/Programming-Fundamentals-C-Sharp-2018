using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Hornet_Comm
{
    class Program
    {
        public static void Main()
        {
            var messages = new List<string>();
            var broadcasts = new List<string>();
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "Hornet is Green")
                {
                    break;
                }

                var parts = line.Split(new[] { " <-> "}, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length != 2)
                {
                    continue;
                }

                var firstQuery = parts[0];
                var secondQuery = parts[1];

                if (firstQuery.All(char.IsDigit) &&
                    secondQuery.All(char.IsLetterOrDigit))
                {
                    //private massage

                    string revesedQuery = string.Join("", firstQuery.Reverse());
                    string revesedQuery2ndWay = new string(firstQuery.Reverse().ToArray());
                    messages.Add($"{revesedQuery} -> {secondQuery}");
                }
                else if (firstQuery.All(s => !char.IsDigit(s)) &&
                    secondQuery.All(char.IsLetterOrDigit))
                {
                    //broadcast
                    var transformed = new StringBuilder();
                    foreach (var symbol in secondQuery)
                    {
                        if (char.IsUpper(symbol))
                        {
                            transformed.Append(symbol.ToString().ToLower());
                        }
                        else if (char.IsLower(symbol))
                        {
                            transformed.Append(symbol.ToString().ToUpper());
                        }
                        else
                        {
                            transformed.Append(symbol);
                        }
                        
                    }
                    broadcasts.Add($"{transformed} -> {firstQuery}");
                }
            }

            Console.WriteLine("Broadcasts:");
            Console.WriteLine(broadcasts.Any()
                ? string.Join(Environment.NewLine,broadcasts)
                :"None");
            Console.WriteLine("Messages:");
            Console.WriteLine(messages.Any()
                ? string.Join(Environment.NewLine, messages)
                : "None");

        }
    }
}
