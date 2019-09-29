using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2___Command_Interpreter
{
    class Program
    {
        public static void Main()
        {
            var collection = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var line = Console.ReadLine();
            while (line != "end")
            {
                var commandProps = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var command = commandProps[0];

                if (command == "reverse")
                {
                    var reverseStart = int.Parse(commandProps[2]);
                    var reverseCount = int.Parse(commandProps[4]);
                    if (IsValid(collection, reverseStart, reverseCount))
                    {
                        Reverse(collection, reverseStart, reverseCount);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    

                }
                else if (command == "sort")
                {
                    var sortStart = int.Parse(commandProps[2]);
                    var sortCount = int.Parse(commandProps[4]);
                    if (IsValid(collection, sortStart, sortCount))
                    {
                        Sort(collection, sortStart, sortCount);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                   
                }
                else if (command == "rollRight")
                {
                    var rollRightCount = int.Parse(commandProps[1]);
                    if (rollRightCount >= 0)
                    {
                        RollRight(collection, rollRightCount);

                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                   
                }
                else if (command == "rollLeft")
                {
                    var rollLeftCount = int.Parse(commandProps[1]);
                    if (rollLeftCount >= 0)
                    {
                        RollLeft(collection, rollLeftCount);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    

                }
                line = Console.ReadLine();

            }

            Console.WriteLine($"[{string.Join(", ", collection)}]");
        }

        public static bool IsValid(List<string> collection, int start, int count)
        {
            bool result = start >= 0 &&
               count >= 0 &&
               start < collection.Count &&
               (start + count) <= collection.Count;

            return result;
        }

        private static void RollLeft(List<string> collection, int rollLeftCount)
        {
            var rotations = rollLeftCount % collection.Count;
            for (int i = 0; i < rotations; i++)
            {
                var firstElement = collection[0];
                for (int r = 0; r < collection.Count - 1; r++)
                {
                    collection[r] = collection[r + 1];
                }
                collection[collection.Count - 1] = firstElement;
            }
        }

        private static void RollRight(List<string> collection, int rollRightCount)
        {
            var rotations = rollRightCount % collection.Count;
            for (int i = 0; i < rotations; i++)
            {
                var firstElement = collection[collection.Count - 1];
                for (int r = collection.Count - 1; r > 0; r--)
                {
                    collection[r] = collection[r - 1];
                }
                collection[0] = firstElement;
            }
        }

        private static void Sort(List<string> collection, int sortStart, int sortCount)
        {
            collection.Sort(sortStart, sortCount, null);
        }

        private static void Reverse(List<String> collection, int reverseStart, int reverseCount)
        {
            collection.Reverse(reverseStart, reverseCount);
        }
    }
}
