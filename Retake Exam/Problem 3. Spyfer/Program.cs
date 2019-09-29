using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Spyfer
{
    class Program
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var lastCount = 0;

            while (true)
            {
                if (lastCount == inputLine.Count)
                {
                    break;
                }

                lastCount = inputLine.Count;
                    

                for (int i = 0; i < inputLine.Count; i++)
                {

                    if (i == inputLine.Count - 1)
                    {
                        break;
                    }

                    var sum = 0;
                    var previsiousNum = 0;
                    var currentNum = inputLine[i];
                    if (i == 0)
                    {
                        previsiousNum = 0;
                        var nextNum = inputLine[i + 1];
                        sum = nextNum;
                        if (sum == currentNum)
                        {
                            inputLine.RemoveAt(i + 1);
                            break;
                        }
                    }
                    else
                    {
                        previsiousNum = inputLine[i - 1];
                        var nextNum = inputLine[i + 1];
                        sum = (previsiousNum + nextNum);
                        if (sum == currentNum)
                        {
                            inputLine.RemoveAt(i - 1);
                            inputLine.RemoveAt(i);
                            break;
                        }
                    }
                }

            }

            Console.WriteLine(string.Join(" ",inputLine));

        }
    }
}
