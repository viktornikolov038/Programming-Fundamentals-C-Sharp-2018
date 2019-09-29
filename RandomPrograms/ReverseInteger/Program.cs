using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseInteger
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var command = Console.ReadLine();
            var smallestNum = int.MaxValue;
            var biggersNum = int.MinValue;

            var minNumbers = new List<int>();
            var maxNumbers = new List<int>();
            foreach (var item in input)
            {
                var number = item.ToList();
                for (int i = 0; i < number.Count; i++)
                {
                    if (number.Count > 1)
                    {
                        var lastNum = number[number.Count - 1];
                        number[number.Count - 1] = number[0];
                        for (int r = 0; r < number.Count - 1; r++)
                        {

                            number[r] = number[r + 1];
                        }
                        number[number.Count - 2] = lastNum;
                    }
                    
                    var listAsString = String.Join("", number.ConvertAll(x => x.ToString()).ToArray());
                    var currentNum = int.Parse(listAsString);
                    if (smallestNum > currentNum)
                    {
                        smallestNum = currentNum;

                    }
                    if (biggersNum < currentNum)
                    {
                        biggersNum = currentNum;

                    }

                }
                
                minNumbers.Add(smallestNum);

                
                maxNumbers.Add(biggersNum);

                smallestNum = int.MaxValue;
                biggersNum = int.MinValue;

            }
            if (command == "Min")
            {
                
                Console.WriteLine(string.Join(", ", minNumbers));
                Console.WriteLine(minNumbers.Sum());
            }
            else
            {
               
                Console.WriteLine(string.Join(", ", maxNumbers));
                 Console.WriteLine(maxNumbers.Sum());
            }

            // 123 
            // 231

        }
    }
}
