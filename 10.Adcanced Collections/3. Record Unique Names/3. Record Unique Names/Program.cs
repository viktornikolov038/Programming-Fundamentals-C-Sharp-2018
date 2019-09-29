using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Record_Unique_Names
{
    class Program
    {
        public static void Main()
        {
            var loop = int.Parse(Console.ReadLine());
            var uniqueNames = new HashSet<string>();
            for (int i = 0; i < loop; i++)
            {
                var name = Console.ReadLine();
                uniqueNames.Add(name);
            }
            foreach (var name in uniqueNames)
            {
                Console.WriteLine(name);
            }
            //Console.WriteLine("===");
            //THIS WORKS WITH LIST BUT ITS SLOWER THAN HASHSETS
            //var listOfuniqueNames = new List<string>();
            //for (int i = 0; i < loop; i++)
            //{
            //    var name = Console.ReadLine();  
            //    if (!listOfuniqueNames.Contains(name))
            //    {
            //        listOfuniqueNames.Add(name);
            //    }

            //}
            //Console.WriteLine("===");
            //foreach (var name in listOfuniqueNames)
            //{
            //    Console.WriteLine(name);
            //}
        }
    }
}
