using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Dict_Ref_Advanced
{
    class Program
    {
        public static void Main()
        {
            var resultDic = new Dictionary<string, List<int>>(); 

            var line = Console.ReadLine();

            while (line != "end")
            {
                var inputParams = line.Split(new[] { ',', ' ', '>', '-'}, StringSplitOptions.RemoveEmptyEntries);
                var currentKey = inputParams[0];

                var numbers = -1;
                if (int.TryParse(inputParams[1], out numbers))
                {
                    if (!resultDic.ContainsKey(currentKey))
                    {
                        resultDic[currentKey] = new List<int>();
                    }

                    for (int i = 1; i < inputParams.Length; i++)
                    {
                        resultDic[currentKey].Add(int.Parse(inputParams[i]));
                    }
                }
                else
                {
                    string otherKey = inputParams[1];
                    if (resultDic.ContainsKey(otherKey))
                    {
                        resultDic[currentKey] = new List<int>(resultDic[otherKey]);
                    }
                }
                line = Console.ReadLine();           
            }


            foreach (var name in resultDic)
            {
                Console.WriteLine($"{name.Key} === {string.Join(", ", name.Value)}");
            }

        }
    }
}
