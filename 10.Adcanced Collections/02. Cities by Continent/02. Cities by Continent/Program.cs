using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Cities_by_Continent
{
    class Program
    {
        public static void Main()
        {
            var loop = int.Parse(Console.ReadLine());
            var continentCountryCity = new Dictionary<string, Dictionary<string,List<string>>>();
            for (int i = 0; i < loop; i++)
            {
                var tokens = Console.ReadLine().Split();
                string continent = tokens[0];
                var country = tokens[1];
                var city = tokens[2];
                if (!continentCountryCity.ContainsKey(continent))
                {
                    continentCountryCity[continent] = new Dictionary<string, List<string>>();
                }
                if (!continentCountryCity[continent].ContainsKey(country))
                {
                    continentCountryCity[continent][country] = new List<string>(); 
                }
                continentCountryCity[continent][country].Add(city);
            }
            foreach (var continent in continentCountryCity.Keys)
            {
                Console.WriteLine(continent + ":");
                var currentCountry = continentCountryCity[continent];
                foreach (var country in currentCountry.Keys)
                {
                    Console.WriteLine("   {0} -> {1}",country,string.Join(", ",continentCountryCity[continent][country]));
                }
            }
        }
    }
}
