using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.StringRepeater
{
    class Program
    {
        public static void Main()
        {
            string wordPart = Console.ReadLine();
            int counter = int.Parse(Console.ReadLine());
            Console.WriteLine(StringRepeater(wordPart,counter));
        }
        public static string StringRepeater(string wordPart,int counter)
        {
            string fullString = string.Empty;
            for (int i = 0; i < counter; i++)
            {
                fullString += wordPart;
            }
            return fullString;
        }
    }
}
