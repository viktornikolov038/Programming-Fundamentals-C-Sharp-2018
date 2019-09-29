using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            DrawFirstandLastRow(n);
            for (int i = 0; i < n-2; i++)
            {
                DrawMiddleRows(n);
            }
            DrawFirstandLastRow(n);
        }
        public static void DrawFirstandLastRow(int n)
        {
            Console.WriteLine(new string('-',2*n));
        }
        public static void DrawMiddleRows(int n)
        {
            Console.Write("-");
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");

        }
    }
}
