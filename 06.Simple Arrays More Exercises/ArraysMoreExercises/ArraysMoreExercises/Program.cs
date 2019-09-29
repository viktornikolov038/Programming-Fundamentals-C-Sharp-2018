using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ArraysMoreExercises
{
    class Program
    {
        public static void Main(string[] args)
        {
            var phoneNumbers = Console.ReadLine().Split();
            var contactsNames = Console.ReadLine().Split();
            var command = Console.ReadLine().Split();
            while (command[0] != "done")
            {
                if (command[0] == "call")
                {
                    for (int i = 0; i < phoneNumbers.Length; i++)
                    {
                        if (command[1] == phoneNumbers[i])
                        {
                            Console.WriteLine("calling {0}...",contactsNames[i]);
                            if (SumOfDigits(phoneNumbers[i]))
                            {
                                Console.WriteLine("no answer");
                            }
                            else
                            {
                                Console.WriteLine("call ended. duration: ");
                            }
                        }
                        if (command[1] == contactsNames[i])
                        {
                            Console.WriteLine("calling {0}...",phoneNumbers[i]);
                        }
                    }
                }
                if (command[0] == "message")
                {
                    for (int i = 0; i < phoneNumbers.Length; i++)
                    {
                        if (command[1] == contactsNames[i])
                        {
                            Console.WriteLine("sending sms to {0}...", phoneNumbers[i]);
                        }
                    }
                }
                command = Console.ReadLine().Split();
            }

        }

        public static bool SumOfDigits(string phoneNumber)
        {
            Regex r = new Regex(@"\D");
            string s = Regex.Replace(phoneNumber, @"\D", "");
            int number = int.Parse(s);
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
