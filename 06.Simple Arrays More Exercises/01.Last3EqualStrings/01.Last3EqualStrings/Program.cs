using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Last3EqualStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            int counter = 1;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == arr[i - 1])
                {
                    counter++;

                    if (counter == 3)
                    {
                        Console.WriteLine($"{arr[i]} {arr[i]} {arr[i]}");
                        break;
                    }
                }
                else
                {
                    counter = 1;
                }
            }
        }
    }
}
