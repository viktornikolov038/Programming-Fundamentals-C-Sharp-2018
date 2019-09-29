using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneNumbers = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();
            string[] names = Console.ReadLine()
                .Split(' ');
            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                var wantedName = Console.ReadLine();
                if (wantedName == "done")
                {
                    break;
                }
                else if (wantedName == names[1])
                {
                    Console.WriteLine(phoneNumbers[1]);
                }
                else if (wantedName == names[2])
                {
                    Console.WriteLine(phoneNumbers[2]);
                }
               
            }
             
        }
    }
}
