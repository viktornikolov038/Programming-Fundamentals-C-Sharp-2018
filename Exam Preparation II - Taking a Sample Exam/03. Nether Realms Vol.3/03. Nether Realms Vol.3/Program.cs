using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Nether_Realms_Vol._3
{
    class Program
    {
        public class Demon
        {
            public int Health { get; set;}

            public string Name { get; set; }

            public double Damage { get; set; }
        }

        public static void Main()
        {
            var result = new SortedDictionary<string,Demon>();
            var demonsNames = Console.ReadLine().Split(new[] { ' ', ','}, StringSplitOptions.RemoveEmptyEntries);
            var regex = new Regex(@"-?\d+\.?\d*");
           
            foreach (var demon in demonsNames)
            {
                var health = 0;
                var healthSymbols = demon.Where(a => !char.IsDigit(a) 
                                        && a != '+' 
                                        && a!= '-' 
                                        && a != '*' 
                                        && a != '/'
                                        && a != '.');
                foreach (var symbol in healthSymbols)
                {
                    health += (int)symbol;
                }

                var matches = regex.Matches(demon);
                var damage = 0.0;
                foreach (Match match in matches)
                {
                    damage += double.Parse(match.Value);
                }

                foreach (var symbol in demon)
                {
                    if (symbol == '*')
                    {
                        damage *= 2;
                    }
                    else if (symbol == '/')
                    {
                        damage /= 2;
                    }
                
                }

                result.Add(demon,new Demon
                {
                    Health = health,
                    Damage = damage,
                    Name = demon
                });
            }
            foreach (var demon in result)
            {
                var currentDemon = demon.Value;
                Console.WriteLine($"{currentDemon.Name} - {currentDemon.Health} health, {currentDemon.Damage:F2} damage ");
            }
        }
    }
}
