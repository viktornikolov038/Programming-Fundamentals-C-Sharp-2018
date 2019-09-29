using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Min_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int minNum = GetMin(a,GetMin(b,c));
            Console.WriteLine(minNum);
        }
        public static int GetMin(int a,int b)
        {
            if (a <= b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
