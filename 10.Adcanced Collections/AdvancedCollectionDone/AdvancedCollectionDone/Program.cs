using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCollectionDone
{
    class Program
    {
        public static void Main()
        {
            //var n = int.Parse(Console.ReadLine());
            //var grades = new Dictionary<string, List<double>>();
            //for (int i = 0; i < n; i++)
            //{
            //    var tokens = Console.ReadLine().Split(' ');
            //    var name = tokens[0];
            //    var grade = double.Parse(tokens[1]);
            //    if (!grades.ContainsKey(name))
            //    {
            //        grades[name] = new List<double>();
            //    }
            //    grades[name].Add(grade);
            //}
            //foreach (var nameAndGrade in grades)
            //{
            //    var name = nameAndGrade.Key;
            //    var gradesByName = nameAndGrade.Value;
            //    Console.WriteLine("{0} -> {1} (avg:{2:f2})",
            //        name,
            //        string.Join(" ", gradesByName.Select(p => string.Format("{0:f2}", p))),
            //        gradesByName.Average());
            //}



            //var n = int.Parse(Console.ReadLine());
            //var data = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            //for (int i = 0; i < n; i++)
            //{
            //    var tokens = Console.ReadLine().Split();

            //    var continent = tokens[0];
            //    var country = tokens[1];
            //    var town = tokens[2];

            //    if (!data.ContainsKey(continent))
            //    {
            //        data[continent] = new SortedDictionary<string, SortedSet<string>>();
            //    }

            //    if (!data[continent].ContainsKey(country))
            //    {
            //        data[continent][country] = new SortedSet<string>();
            //    }

            //    data[continent][country].Add(town);
            //}
            //foreach (var continents in data)
            //{
            //    var continent = continents.Key;
            //    var country = continents.Value;
            //    Console.WriteLine("{0}",continent);
            //    foreach (var item in country)
            //    {
            //        Console.WriteLine("  {0} -> {1}",item.Key,string.Join(", ",item.Value));
            //    }
            //}


            var townsData = new Dictionary<string, List<string>>();
            addTown(townsData, "Bulgaria", "Kyustendil");
            addTown(townsData, "Bulgaria", "Sofia");
            addTown(townsData, "Bulgaria", "Varna");
            addTown(townsData, "England", "Manchester");
            addTown(townsData, "England", "London");
            foreach (var country in townsData)
            {
                Console.WriteLine(country.Key);
                Console.WriteLine("  " + string.Join(", ",country.Value));
            }
        }

        public static void addTown(Dictionary<string, List<string>> townsData, string country, string town)
        {
            if (!townsData.ContainsKey(country))
            {
                townsData[country] = new List<string>();
            }
            townsData[country].Add(town);
        }
    }
}
