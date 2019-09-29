using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Nether_Realms
{
    

    class Program
    {
        public static void Main()
        {
            var demons = Console.ReadLine()
                .Split(new[] { ' ',',' }, StringSplitOptions.RemoveEmptyEntries);

            var result = new SortedDictionary<string, Demon>();
            foreach (var demon in demons)
            {

                var healthSymbols = demon.Where(s =>
                                        !char.IsDigit(s) &&
                                        s != '+' &&
                                        s != '-' &&
                                        s != '*' &&
                                        s != '/' &&
                                        s != '.');
                var health = 0;
                foreach (var symbol in healthSymbols)
                {
                    health += (int)symbol;
                }

                var regex = new Regex(@"-?\d+\.?\d*");
                var matches = regex.Matches(demon);
                var damage = 0.0;
                foreach  (Match match in matches)
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
                result.Add(demon, new Demon
                {
                    Name = demon,
                    Damage = damage,
                    Health = health                  
                });
            }

            foreach (var demon in result.Values)
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage ");
            }
        }
    }
}
