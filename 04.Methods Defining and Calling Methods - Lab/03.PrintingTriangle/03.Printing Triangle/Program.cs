using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        public static void Main()
        {
            int end = int.Parse(Console.ReadLine());
            for (int i = 0; i < end; i++)
            {
                PrintLine(1, i);

            }
            PrintLine(1, end);
            for (int i = end - 1; i >= 0; i--)
            {
                PrintLine(1, i);
            }
        }
        public static void PrintLine(int start, int end)
        {
            for (int i = 1; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
