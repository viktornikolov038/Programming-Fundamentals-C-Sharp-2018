using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Cities_by_Continent_and_Country
{
    class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var result = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < n; i++)
            {
                var props = Console.ReadLine().Split();
                var currentContinent = props[0];
                var currentCountry = props[1];
                var currentCity = props[2];
                if (!result.ContainsKey(currentContinent))
                {
                    result[currentContinent] = new Dictionary<string, List<string>>();
                }

                if (!result[currentContinent].ContainsKey(currentCountry))
                {
                    result[currentContinent][currentCountry] = new List<string>();
                }
                result[currentContinent][currentCountry].Add(currentCity);
            }

            
                
            
            result = result.Values
                .OrderBy(a => a.Keys)               
                .ToDictionary(a => a.Keys, a => a.Values);

            

            foreach (var continent in result)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var kur in continent.Value)
                {
                    Console.WriteLine($"  {kur.Key} -> {string.Join(", ",kur.Value)}");
                }
            }
        }
    }
}
