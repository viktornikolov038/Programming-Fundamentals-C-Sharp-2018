using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int operand1 = int.Parse(Console.ReadLine());
            char operator1 = char.Parse(Console.ReadLine());
            int operand2 = int.Parse(Console.ReadLine());

            switch (operator1)
            {
                case '+':
                    Console.WriteLine($"{operand1} + {operand2} = {operand1 + operand2}");
                    break;
                case '-':
                    Console.WriteLine($"{operand1} - {operand2} = {operand1 - operand2}");
                    break;
                case '*':
                    Console.WriteLine($"{operand1} * {operand2} = {operand1 * operand2}");
                    break;
                case '/':
                    Console.WriteLine($"{operand1} / {operand2} = {operand1 / operand2}");
                    break;
            }
        }
    }
}