using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_substring
{
    class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var pattern = Console.ReadLine().ToLower();
            var counter = 0;
            var index = text.IndexOf(pattern);
            while (index != -1)
            {

                counter++;
                //sled kato e namerilo suvpadenie trqbva da zapochnem s sledvashtata duma
                index = text.IndexOf(pattern, index + 1);

            }
            Console.WriteLine(counter);

        }
    }
}
