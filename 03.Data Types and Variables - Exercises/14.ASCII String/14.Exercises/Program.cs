using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string fullWord = "";
            for (int i = 0; i < n; i++)
            {
                int letters = int.Parse(Console.ReadLine());
                char toChar = Convert.ToChar(letters);
                fullWord += toChar;
            }
            Console.WriteLine(fullWord);
        }
    }
}
