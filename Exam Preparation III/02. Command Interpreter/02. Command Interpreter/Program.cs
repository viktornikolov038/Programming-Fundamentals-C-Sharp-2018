using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Command_Interpreter
{
    class Program
    {
        public static void Main()
        {
            var collection = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var inputParams = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string command = inputParams[0];
                switch (command)
                {
                    case "reverse":
                        var reverseStart = int.Parse(inputParams[2]);
                        var reverseCount = int.Parse(inputParams[4]);
                        if (IsValid(collection,reverseStart,reverseCount))
                        {
                            Reverse(collection, reverseStart, reverseCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");

                        }
                        break;

                    case "sort":
                        var sortStart = int.Parse(inputParams[2]);
                        var sortCount = int.Parse(inputParams[4]);
                        if (IsValid(collection,sortStart,sortCount))
                        {
                            Sort(collection, sortStart, sortCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;

                    case "rollLeft":
                        var rollLeftCount = int.Parse(inputParams[1]);
                        if (rollLeftCount >= 0)
                        {
                            RollLeft(collection, rollLeftCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");

                        }
                        break;

                    case "rollRight":
                        var rollRightCount = int.Parse(inputParams[1]);
                        if (rollRightCount >= 0)
                        {
                            RollRight(collection, rollRightCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");

                        }
                        break;

                }
                inputLine = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", collection)}]");
        }

        private static bool IsValid(List<string> collection, int start, int count)
        {
            bool result = start >= 0 &&
                count >= 0 &&
                start < collection.Count &&
                (start + count) <= collection.Count;

            return result;

        }

        private static void Reverse(List<string> collection, int reverseStart, int reverseCount)
        {
            collection.Reverse(reverseStart, reverseCount);
            //var portion = new List<string>();

            //for (int i = reverseStart; i < reverseCount; i++)
            //{
            //    portion.Add(collection[i]);

            //}
            //portion.Reverse();
            //collection.RemoveRange(reverseCount, reverseCount);
            //collection.InsertRange(reverseStart, portion);
        }

        private static void Sort(List<string> collection, int sortStart, int sortCount)
        {
            collection.Sort(sortStart, sortCount, null);
        }

        private static void RollLeft(List<string> collection, int rollLeftCount)
        {
            int rotations = rollLeftCount % collection.Count;
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
            int rotations = rollRightCount % collection.Count;

            for (int i = 0; i < rotations; i++)
            {
                var lastElement = collection[collection.Count - 1];
                for (int r = collection.Count - 1; r > 0; r--)
                {
                    collection[r] = collection[r - 1];
                }
                collection[0] = lastElement;
            }
        }

    }
}
