using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.String_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(StringEncryption(n));
        }
        public static string StringEncryption(int n)
        {
            string fullEncrypted = string.Empty;
            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                int charToASCII = (int)letter;
                int ASCIIlastDigit = charToASCII % 10;
                int ASCIIfirstDigit = charToASCII / 100;
                string leftMiddleNum = Convert.ToString(ASCIIfirstDigit);
                string rightMiddleNum = Convert.ToString(ASCIIlastDigit);
                int firstLetterASCII = charToASCII + ASCIIlastDigit;
                char firstLetterChar = Convert.ToChar(firstLetterASCII);
                int lastLetterASCII = charToASCII - ASCIIfirstDigit;
                char lastLetterChar = Convert.ToChar(lastLetterASCII);
                string fullCode = firstLetterChar + leftMiddleNum + rightMiddleNum + lastLetterChar;
                fullEncrypted += fullCode;
                return fullCode;
            }
            return "kit";
            
        }
    }
}
