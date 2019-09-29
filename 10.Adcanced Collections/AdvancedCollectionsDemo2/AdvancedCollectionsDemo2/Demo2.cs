using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCollectionsDemo2
{
    class Demo2
    {
        public static void Main()
        {
            var list = new List<string>();
            var set = new HashSet<string>();
            list.Add("Kyustendil");
            list.Add("Sofia");
            list.Add("Plovdiv");
            list.Add("Sofia");
            Console.WriteLine(string.Join(", ", list));
            set.Add("Kyustendil");
            set.Add("Sofia");
            set.Add("Plovdiv");
            set.Add("Sofia");
            set.Add("Varna");
            set.Remove("Plovdiv");
            Console.WriteLine(set.Count);
            Console.WriteLine(string.Join(", ", set));

            Console.WriteLine(set.Contains("Ruse"));
            Console.WriteLine(set.Contains("Kyustendil"));




        }
    }
}
