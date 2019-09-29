using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.NSA
{
    class Program
    {
        public static void Main()
        {
            var result = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                var command = Console.ReadLine();
                if (command.ToLower() == "quit")
                {
                    break;
                }
                
                var commandParams = command.Split(new[] {" -> "},StringSplitOptions.RemoveEmptyEntries).ToArray();
                
                var countryName = commandParams[0];
                var spyName = commandParams[1];
                var daysInService = long.Parse(commandParams[2]);
                
                if (!result.ContainsKey(countryName))
                {
                    result[countryName] = new Dictionary<string, long>();
                }

                if (!result[countryName].ContainsKey(spyName))
                {
                    result[countryName][spyName] = new long();
                }

                result[countryName][spyName] = daysInService;

            }

            


            result = result
                .OrderByDescending(a => a.Value.Count)
                .ToDictionary(a => a.Key, a => a.Value);
            
            
            foreach (var country in result)
                {
                    Console.WriteLine($"Country: {country.Key}");
                    
                var innerDic = country.Value
                    .OrderByDescending(a => a.Value)
                    .ToDictionary(a => a.Key, a => a.Value);
                    foreach (var soldier in innerDic)
                    {
                        Console.WriteLine($"**{soldier.Key} : {soldier.Value}");
                    }
                }
        }
    }
}
