using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Dict_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultDic = new Dictionary<string, int>();
            var line = Console.ReadLine();

            while (line != "end")
            {
                var tokens = line.Split();
                var firstElemet = tokens[0];
                var lastElement = tokens[tokens.Length - 1];
                var number = 0;
                if (int.TryParse(lastElement, out number))
                {
                    resultDic[firstElemet] = number;
                }
                else
                {
                    if (resultDic.ContainsKey(lastElement))
                    {
                        resultDic[firstElemet] = resultDic[lastElement];
                    }

                }
                line = Console.ReadLine();
            }

            foreach (var kvp in resultDic)
            {
                Console.WriteLine($"{kvp.Key} === {kvp.Value}");
            }
        }

    }
}
