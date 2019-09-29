using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.RotateStingArr
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ');
            string[] newArray = new string[words.Length];
            newArray[0] = words[words.Length - 1];
            for (int i = 0; i < words.Length - 1; i++)
            {
                newArray[i + 1] = words[i];
            }
            var finalResult = string.Join(" ", newArray);
            Console.WriteLine(finalResult);
        }
    }

}
