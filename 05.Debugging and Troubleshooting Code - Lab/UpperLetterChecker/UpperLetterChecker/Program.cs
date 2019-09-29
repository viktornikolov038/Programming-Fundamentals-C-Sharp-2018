using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperLetterChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            if (UpperLetterChecker(password))
            {
                Console.WriteLine("Use only upper letters");
            }
            else
            {
                Console.WriteLine("succesfull login");
            }
        }
        public static bool UpperLetterChecker(string password)
        {
            foreach (char symbol in password.ToString())
            {
                char letter = (char)(symbol - '0');
                if (letter > 90)
                {
                    return true;
                }
                else
                {
                    return false;

                }
                
            }
            return true;
        }
    }
}
