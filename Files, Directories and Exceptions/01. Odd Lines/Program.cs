using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Odd_Lines
{
    public class Program
    {
        public static void Main()
        {
            var text = File.ReadAllLines("input.txt");
            
            for (int i = 0; i < text.Length; i++)
            {
                File.AppendAllText("output2.txt",$"{i + 1}. {text[i]}" + Environment.NewLine);
                
            }
            
        }
    }
}
