using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Dict_Ref_Advanced
{
    class Program
    {
        public static void Main()
        {
            var result = new Dictionary<string, List<int>>();
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "end")
                {
                    break;
                }
                var inputParams = inputLine.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                var name = inputParams[0];
                var values = inputParams[1].Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                var number = 0;
                var numOrName = int.TryParse(values[0], out number);
                if (numOrName)
                {
                    if (!result.ContainsKey(name))
                    {
                        result[name] = new List<int>();
                    }
                    for (int i = 0; i < values.Length; i++)
                    {
                        result[name].Add(int.Parse(values[i]));
                    }
                }
                else
                {
                    var otherKey = values[0];
                    if (result.ContainsKey(otherKey))
                    {
                        if (!result.ContainsKey(name))
                        {
                            result[name] = new List<int>();
                        }

                        foreach (var kit in result[otherKey])
                        {
                            result[name].Add(kit);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            foreach (var guy in result)
            {
                Console.WriteLine($"{guy.Key} === {string.Join(", ", guy.Value)}");
            }
        }
    }
}
