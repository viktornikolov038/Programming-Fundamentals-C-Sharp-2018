using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.GreaterOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            TypeChecker(type);

        }
        public static void TypeChecker(string type)
        {
            if (type == "int")
            {
                int firstInput = int.Parse(Console.ReadLine());
                int secondInput = int.Parse(Console.ReadLine());
                int max = IntegerMax(firstInput, secondInput);
                Console.WriteLine(max);
            }
            else if (type == "char")
            {
                char firstInput = char.Parse(Console.ReadLine());
                char secondInput = char.Parse(Console.ReadLine());
                char max = CharMax(firstInput,secondInput);
                Console.WriteLine(max);
            }
            else if (type == "string")
            {
                string firstInput = Console.ReadLine();
                string secondInput = Console.ReadLine();
                string max = StringMax(firstInput, secondInput);
                Console.WriteLine(max); 
            }
        }
        public static int IntegerMax(int firstInput,int secondInput)
        {
            return Math.Max(firstInput, secondInput);
        }
        public static char CharMax(char firstInput,char secondInput)
        {

            if (firstInput >= secondInput)
            {
                return firstInput;
            }
            else
            {
                return secondInput;
            }
        }
        public static string StringMax(string firstInput,string secondInput)
        {
            if (firstInput.CompareTo(secondInput) >= 0)
            {
                return firstInput;
            }
            else
            {
                return secondInput;
            }
        }
    }
}
