using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Lab
{
    class Program
    {
        public static void Main()
        {
            //    var population = new Dictionary<string, Dictionary<string, int>>();
            //    population["Bulgaria"] = new Dictionary<string, int>();
            //    population["Bulgaria"]["Sofia"] = 2000000;
            //    population["Bulgaria"]["Kyustendil"] = 40000;

            //    population["England"] = new Dictionary<string, int>();
            //    population["England"]["London"] = 14000000;

            //    addPopulation(population, "China", "Tokyo", 20000000);
            //    addPopulation(population, "USA", "New York", 15000000);
            //    // removes cuntry population.Remove("England");
            //    population["Bulgaria"].Remove("Sofia"); // removes town
            //    foreach (var country in population.Keys)
            //    {
            //        Console.WriteLine("Country : {0}",country);
            //        var populationByTown = population[country];
            //        foreach (var town in populationByTown.Keys)
            //        {
            //            Console.WriteLine("Town {0} -> {1}",town,populationByTown[town]);
            //        }
            //        Console.WriteLine();
            //    }
            //}

            //public static void addPopulation(Dictionary<string, Dictionary<string, int>> population, string country, string town, int townPopulation)
            //{
            //    if (!population.ContainsKey(country))
            //    {
            //        population[country] = new Dictionary<string, int>();
            //    }
            //    population[country][town] = townPopulation;
            //}


            var population = new Dictionary<string, Dictionary<string, int>>();
            addPopulation(population, "Bulgaria", "Kyustendil", 40000);
            addPopulation
            foreach (var country in population.Keys)
            {
                Console.WriteLine("{0} :",country);
                foreach (var town in population[country].Keys)
                {
                    Console.WriteLine("{0} -> {1}", town,population[country][town]);
                }
            }

        }

        public static void addPopulation(Dictionary<string, Dictionary<string, int>> population, string country, string town, int townPopulaton)
        {
            if (!population.ContainsKey(country))
            {
                population[country] = new Dictionary<string, int>();
            }
            population[country][town] = townPopulaton;
        }
    }
}
