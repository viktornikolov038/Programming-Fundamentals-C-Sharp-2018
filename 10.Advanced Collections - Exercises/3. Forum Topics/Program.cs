using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Forum_Topics
{
    class Program
    {
        public static void Main()
        {
            var result = new Dictionary<string, HashSet<string>>();
            while (true)
            {
                var command = Console.ReadLine();

                if (command == "filter")
                {
                    break;
                }
                var commandParams = command.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                var currentTopic = commandParams[0];
                var currentTags = commandParams[1].Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                if (!result.ContainsKey(currentTopic))
                {
                    result[currentTopic] = new HashSet<string>();
                }
                foreach (var tag in currentTags)
                {
                    result[currentTopic].Add(tag);
                }
            }
            var filteredWors = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var kvp in result)
            {
                var isValid = true;
                for (int i = 0; i < filteredWors.Length; i++)
                {
                    var currentTags = kvp.Value;
                    if (!currentTags.Contains(filteredWors[i]))
                    {
                        isValid = false;
                    }
                }
                if (isValid)
                {
                    Console.WriteLine($"{kvp.Key} | #{string.Join(", #",kvp.Value)}");
                }
            }
        }
    }
}