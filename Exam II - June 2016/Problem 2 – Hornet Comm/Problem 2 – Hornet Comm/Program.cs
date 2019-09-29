using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2___Hornet_Comm
{
   

    class Program
    {
        public static void Main()
        {
            var broadcasts = new List<string>();
            var messages = new List<string>();
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "Hornet is Green")
                {
                    break;
                }
                
                var inputParams = inputLine.Split(new string[] {" <-> "},StringSplitOptions.RemoveEmptyEntries);
                if (inputParams.Length != 2)
                {
                    break;
                }
                var firstQuery = inputParams[0];
                var secondQuery = inputParams[1];

                if (firstQuery.All(a => char.IsDigit(a)) && secondQuery.All(a => char.IsLetterOrDigit(a)))
                {
                    var recipiantCode = string.Join("", firstQuery.Reverse());
                    messages.Add($"{recipiantCode} -> {secondQuery}");
                }
                else if (firstQuery.All(a => !char.IsDigit(a)) && secondQuery.All(a => char.IsLetterOrDigit(a)))
                {
                    var frequency = new StringBuilder();
                    foreach (var symbol in secondQuery)
                    {
                        if (char.IsUpper(symbol))
                        {
                            frequency.Append(symbol.ToString().ToLower());
                        }
                        else if (char.IsLower(symbol))
                        {
                            frequency.Append(symbol.ToString().ToUpper());
                        }
                        else
                        {
                            frequency.Append(symbol);
                        }
                    }
                    broadcasts.Add($"{frequency} -> {firstQuery}");
                }               
            }

            Console.WriteLine("Broadcasts:");
            if (broadcasts.Any())
            {
                Console.WriteLine(string.Join(Environment.NewLine, broadcasts));
            }
            else
            {
                Console.WriteLine("None");
            }
            Console.WriteLine("Messages:");
            if (messages.Any())
            {
                Console.WriteLine(string.Join(Environment.NewLine, messages));
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
