using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Placeholders
{
    class Placeholders
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            while (line != "end")
            {
                var lineTwoParts = line.Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var placeholders = lineTwoParts[1].Trim().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var result = lineTwoParts[0].Trim();
                for (int i = 0; i < placeholders.Length; i++)
                {
                    string currentPlaceholder = "{" + i + "}";
                    result = result.Replace(currentPlaceholder, placeholders[i]);
                }
                //result = result.Replace("{", string.Empty);
                //result = result.Replace("}", string.Empty);
                result = result.Replace("->", string.Empty);

                Console.WriteLine(string.Join(" ", result));
                line = Console.ReadLine();
            }
            
        }
    }
}
