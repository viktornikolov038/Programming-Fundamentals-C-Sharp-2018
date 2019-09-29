using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_DecodeRadioFreq
{
    class DecodeRadioFrequencies
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .ToList();

            var result = new List<char>();
            foreach (var item in input)
            {
                result.Add('0');
            }
            char rightNumAsASCII;
            for (int i = 0; i < input.Count; i++)
            {
                var currentInput = input[i].Split('.').ToList();
                var leftPart = currentInput[0];
                var rightPart = currentInput[1];
                int leftNum = Int32.Parse(leftPart);
                int rightNum = Int32.Parse(rightPart);
                var leftNumAsASCII = (char)leftNum;
                rightNumAsASCII = (char)rightNum;
                result[i] = leftNumAsASCII;
            }
            Console.Write(string.Join(string.Empty,result));
            for (int i = 0; i < input.Count; i++)
            {
                var currentInput = input[i].Split('.').ToList();
                var leftPart = currentInput[0];
                var rightPart = currentInput[1];
                int leftNum = Int32.Parse(leftPart);
                int rightNum = Int32.Parse(rightPart);
                var leftNumAsASCII = (char)leftNum;
                rightNumAsASCII = (char)rightNum;
                result[i] = rightNumAsASCII;             
            }
            result.Reverse();
            Console.Write(string.Join(string.Empty, result));
            Console.WriteLine();



        }
    }
}
