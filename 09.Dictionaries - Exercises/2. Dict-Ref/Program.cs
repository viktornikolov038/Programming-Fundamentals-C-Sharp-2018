using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Dict_Ref
{
    class Program
    {
        public static void Main()
        {
            var result = new Dictionary<string, long>();
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "end")
                {
                    break;
                }
                var tokens = inputLine.Split(new[] { " = " }, StringSplitOptions.RemoveEmptyEntries);
                var name = tokens[0];
                var value = 0l;
                var valueOrNot = long.TryParse(tokens[1], out value);
                if (!result.ContainsKey(name))
                {
                    result[name] = 0l;
                }


                if (valueOrNot)
                {
                    result[name] = value;
                }
                else
                {

                    if (result.ContainsKey(tokens[1]))
                    {
                        result[name] = result[tokens[1]];
                    }
                    else
                    {
                        result.Remove(name);
                    }
                    
                }
            }

            foreach (var name in result)
            {
                Console.WriteLine($"{name.Key} === {name.Value}");
            }
        }
    }
}
