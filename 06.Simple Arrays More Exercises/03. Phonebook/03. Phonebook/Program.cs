using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Phonebook
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            string[] names = Console.ReadLine().Split(' ');

            string askedName = Console.ReadLine();
            while (askedName != "done")
            {
                PrintElements(names, numbers, askedName);
                askedName = Console.ReadLine();
            }
        }

        public static void PrintElements(string[] names, string[] numbers,string askedName)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == askedName)
                {
                    Console.WriteLine("{0} -> {1}",names[i],numbers[i]);
                }
            }
            
        }
    }
}
