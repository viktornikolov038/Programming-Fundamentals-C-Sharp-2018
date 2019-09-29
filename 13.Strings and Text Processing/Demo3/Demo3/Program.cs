using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    class Program
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();


            while (inputLine != "end")
            {
                var inputParams = inputLine.Split(new[] { '-', '>', }, StringSplitOptions.RemoveEmptyEntries);
                var sentance = inputParams[0].Trim();
                var placeholders = inputParams[1].Split(new[] { ' ', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int i = 0; i < placeholders.Length; i++)
                {
                    var currentPlaceholer = "{" + i + "}";
                    sentance = sentance.Replace(currentPlaceholer, placeholders[i]);
                }
                Console.WriteLine(sentance);
                inputLine = Console.ReadLine();
            }

        }
    }
}
