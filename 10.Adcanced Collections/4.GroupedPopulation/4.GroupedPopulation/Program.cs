using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.GroupedPopulation
{
    class Program
    {
            public static void Main()
            {
                var loop = int.Parse(Console.ReadLine());
                
                var continentCountryCity = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();
                for (int i = 0; i < loop; i++)
                {
                    var tokens = Console.ReadLine().Split();
                    string continent = tokens[0];
                    var country = tokens[1];
                    var city = tokens[2];
                    if (!continentCountryCity.ContainsKey(continent))
                    {
                        continentCountryCity[continent] = new SortedDictionary<string, SortedSet<string>>();
                    }
                    if (!continentCountryCity[continent].ContainsKey(country))
                    {
                        continentCountryCity[continent][country] = new SortedSet<string>();
                    }
                    continentCountryCity[continent][country].Add(city);
                }
                foreach (var continent in continentCountryCity.Keys)
                {
                    Console.WriteLine(continent + ":");
                    var currentCountry = continentCountryCity[continent];
                    foreach (var country in currentCountry.Keys)
                    {
                        Console.WriteLine("   {0} -> {1}", country, string.Join(", ", continentCountryCity[continent][country]));
                    }
                }
            }
        }
    }