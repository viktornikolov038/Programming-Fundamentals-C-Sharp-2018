using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = ulong.Parse(Console.ReadLine());
            var secondNum = ulong.Parse(Console.ReadLine());
            ulong lowerNum = Math.Min(firstNum, secondNum);
            ulong biggerNum = Math.Max(firstNum, secondNum);
            string type = "";
            if (biggerNum >= byte.MinValue && biggerNum <= byte.MaxValue)
            {
                Console.WriteLine("bigger type: byte");
                type = "byte";
            }
            else if (biggerNum >= ushort.MinValue && biggerNum <= ushort.MaxValue)
            {
                Console.WriteLine("bigger type: ushort");
                type = "ushort";
            }
            else if (biggerNum >= uint.MinValue && biggerNum <= int.MaxValue)
            {
                Console.WriteLine("bigger type: uint");
                type = "uint";
            }
            else if (biggerNum >= ulong.MinValue && biggerNum <= ulong.MaxValue)
            {
                Console.WriteLine("bigger type: ulong");
                type = "ulong";
            }

            //lower
            if (lowerNum >= byte.MinValue && lowerNum <= byte.MaxValue)
            {
                Console.WriteLine("smaller type: byte");
                type = "byte";
            }
            else if (lowerNum >= ushort.MinValue && lowerNum <= ushort.MaxValue)
            {
                Console.WriteLine("smaller type: ushort");
                type = "ushort";
            }
            else if (lowerNum >= uint.MinValue && lowerNum <= int.MaxValue)
            {
                Console.WriteLine("smaller type: uint");
                type = "uint";
            }
            else if (lowerNum >= ulong.MinValue && lowerNum <= ulong.MaxValue)
            {
                Console.WriteLine("smaller type: ulong");
                type = "ulong";
            }
            //type
            if (type == "byte")
            {
                Console.Write($"{biggerNum} can overflow {type} ");
                Console.Write(Math.Round(biggerNum/(double)byte.MaxValue));
                Console.WriteLine(" times");
            }
            else if (type == "ushort")
            {
                Console.Write($"{biggerNum} can overflow {type} ");
                Console.Write(Math.Round(biggerNum /(double)ushort.MaxValue));
                Console.WriteLine(" times");
            }
            else if (type == "uint")
            {
                Console.Write($"{biggerNum} can overflow {type} ");
                Console.Write(Math.Round(biggerNum / (double)uint.MaxValue));
                Console.WriteLine(" times");
            }
            else if (type == "ulong")
            {
                Console.Write($"{biggerNum} can overflow {type} ");
                Console.Write(Math.Round(biggerNum / (double)ulong.MaxValue));
                Console.WriteLine(" times");
            }
        }
    }
}
