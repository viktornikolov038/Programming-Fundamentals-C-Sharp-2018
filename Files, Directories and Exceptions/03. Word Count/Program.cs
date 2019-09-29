using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Word_Count
{
    public class Program
    {
        public static void Main()
        {
            var words = File.ReadAllText("words.txt").Split(' ');
            var input = File.ReadAllText("Input.txt").ToLower()
                .Split(new[] {' ', '.', '?', '!', '-', ','}, StringSplitOptions.RemoveEmptyEntries);
            var result = new Dictionary<string,int>();
            for (int i = 0; i < words.Length; i++)
            {
                result[words[i]] = 0;
            }

            foreach (var word in input)
            {
                if (result.ContainsKey(word))
                {
                    result[word]++;
                }
            }

            result = result.OrderByDescending(w => w.Value).ToDictionary(w => w.Key, w => w.Value);

            foreach (var kvp in result)
            {
                File.AppendAllText("Output.txt",$"{kvp.Key} - {kvp.Value}" + Environment.NewLine);
            }
        }
    }
}
