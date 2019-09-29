using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordRepeat
{
    class Program
    {
        static void Main(string[] args)
        {
            var password = Console.ReadLine();
            var repeatPassowrd = Console.ReadLine();
            while (repeatPassowrd != password)
            {
                Console.WriteLine("Repeated password must be the same");
                repeatPassowrd = Console.ReadLine();
            }
            Console.WriteLine("succesfull register");
        }
    }
}
