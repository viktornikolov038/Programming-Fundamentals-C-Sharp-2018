using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayandListAlgorithms
{
    class Program
    {
        public static void Main()
        {
            var inputStrings = Console.ReadLine();

            var inputList = new List<string>(inputStrings.Split().ToList());

            bool swapped = true;
            while (swapped)
            {
                swapped = false;
                for (int i = 1; i < inputList.Count; i++)
                {
                    int compare = 0;
                    compare = inputList[i - 1].CompareTo(inputList[i]);
                    if (compare == 1)
                    {
                        var temp = inputList[i - 1];
                        inputList[i - 1] = inputList[i];
                        inputList[i] = temp;
                        swapped = true;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", inputList));

        }
    }
}

