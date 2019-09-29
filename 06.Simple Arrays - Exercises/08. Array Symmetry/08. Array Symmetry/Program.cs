using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Array_Symmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine()
                .Split(' ');
            string[] arr2 = new string[arr1.Length];
            int j = 0;
            bool isTrue = true;
            for (int i = arr1.Length - 1; i >= 0; i--)
            {
                arr2[j] = arr1[i];
                j++;
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr2[i] == arr1[i])
                {
                    isTrue = true;
                }
                else
                {
                    isTrue = false;
                }
            }
            if (isTrue)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
