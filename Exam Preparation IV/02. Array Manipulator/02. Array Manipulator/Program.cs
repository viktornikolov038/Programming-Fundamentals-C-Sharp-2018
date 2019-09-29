using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Manipulator
{
    class Program
    {
        public static void Main()
        {
            var collection = Console.ReadLine()
                .Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            while (true)
            {
                var command = Console.ReadLine();
                var commandParams = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (command == "end")
                {
                    break;
                }

                switch (commandParams[0])
                {
                    case "exchange":
                        var index = int.Parse(commandParams[1]);
                        if (index <= collection.Count - 1)
                        {
                            Exchange(collection, index);
                            
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }                      
                        
                        break;
                    case "max":
                        if (commandParams[1] == "even")
                        {
                            MaxEven(collection);
                        }
                        else
                        {
                            MaxOdd(collection);
                        }
                        
                        break;
                    case "min":
                        if (commandParams[1] == "even")
                        {
                            MinEven(collection);
                        }
                        else
                        {
                            MinOdd(collection);
                        }
                        break;
                }

                if (commandParams[0] == "first")
                {
                    var count = int.Parse(commandParams[1]);
                    if (commandParams[2] == "even")
                    {
                        FirstEven(collection, count);
                    }
                    else
                    {
                        FirstOdd(collection, count);
                    }
                }
                else if(commandParams[0] == "last") 
                {
                    var count = int.Parse(commandParams[1]);
                    if (commandParams[2] == "even")
                    {
                        LastEven(collection, count);
                    }
                    else
                    {
                        LastOdd(collection, count);
                    }
                }


                
            }
            Console.WriteLine($"[{string.Join(", ",collection)}]");
        }

        private static void LastOdd(List<int> collection, int count)
        {
            var result = new List<int>();
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                if (collection[i] % 2 != 0)
                {
                    result.Add(collection[i]);
                }
            }
            
            if (collection.Count < count)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                Console.WriteLine($"[{string.Join(", ", result.Take(count).Reverse())}]");
            }
        }

        private static void LastEven(List<int> collection, int count)
        {
            var result = new List<int>();
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                if (collection[i] % 2 == 0)
                {
                    result.Add(collection[i]);
                }
            }
            if (collection.Count < count)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                Console.WriteLine($"[{string.Join(", ", result.Take(count).Reverse())}]");
            }
        }

        private static void FirstOdd(List<int> collection, int count)
        {
            var result = new List<int>();
            foreach (var element in collection)
            {
                if (element % 2 != 0)
                {
                    result.Add(element);
                }
            }
            if (collection.Count < count)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                Console.WriteLine($"[{string.Join(", ", result.Take(count))}]");
            }
        }

        private static void FirstEven(List<int> collection, int count)
        {
            var result = new List<int>();
            foreach (var element in collection)
            {
                if (element % 2 == 0)
                {
                    result.Add(element);
                }
            }
            if (collection.Count < count)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                Console.WriteLine($"[{string.Join(", ", result.Take(count))}]");
            }
        }

        //odd nechetno 
        private static void MinOdd(List<int> collection)
        {
            var odds = new List<int>();
            var minOdd = int.MaxValue;
            var index = 0;
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                if (collection[i] % 2 != 0)
                {
                    if(minOdd > collection[i])
                    {
                        index = i;
                        minOdd = collection[i];            
                    }
                    
                    odds.Add(minOdd);
                }
            }
            if (odds.Count > 0)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static void MinEven(List<int> collection)
        {
            var evens = new List<int>();
            var minOdd = int.MaxValue;
            var index = 0;
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                if (collection[i] % 2 == 0)
                {
                    if (minOdd > collection[i])
                    {
                        index = i;
                        minOdd = collection[i];
                    }

                    evens.Add(minOdd);
                }
            }
            if (evens.Count > 0)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static void MaxOdd(List<int> collection)
        {
            var odds = new List<int>();
            var maxOdd = int.MinValue;
            var index = 0;
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                if (collection[i] % 2 != 0)
                {
                    if (maxOdd < collection[i])
                    {
                        index = i;
                        maxOdd = collection[i];
                    }

                    odds.Add(maxOdd);
                }
            }
            if (odds.Count > 0)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static void MaxEven(List<int> collection)
        {
            var evens = new List<int>();
            var minOdd = int.MinValue;
            var index = 0;
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                if (collection[i] % 2 == 0)
                {
                    if (minOdd < collection[i])
                    {
                        index = i;
                        minOdd = collection[i];
                    }

                    evens.Add(minOdd);
                }
            }
            if (evens.Count > 0)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("No matches");
            }



        }

        private static List<int> Exchange(List<int> collection, int index)
        {
            
            var count = collection.Count;
            var tokenArray = collection.Skip(index + 1).ToArray();
            foreach (var num in tokenArray)
            {
                collection.Add(num);
            }
            var oldArray = collection.Take(index + 1).ToArray();
            foreach (var num in oldArray)
            {
                collection.Add(num);
            }
            collection.RemoveRange(0, count);
            return collection;
        }
    }
}
