using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3.Nether_Realms
{

    class Program
    {
        public static void Main()
        {


            var demons = Console.ReadLine()
                .Split(new[] { ' ', ',' }
                , StringSplitOptions.RemoveEmptyEntries);

            var result = new SortedDictionary<string, Demon>();

            foreach (var demon in demons)
            {
                var healthSymbols = demon
                   .Where(s =>
                       !char.IsDigit(s) &&
                        s != '+' &&
                        s != '-' &&
                        s != '*' &&
                        s != '/' &&
                        s != '.');

                var health = 0;
                foreach (var healthSymbol in healthSymbols)
                {
                    health += (int)healthSymbol;
                }
               


                var regex = new Regex(@"-?\d+\.?\d*");
                var matches = regex.Matches(demon);

                var damage = 0.0;

                foreach (Match match in matches)
                {
                    var currentNum = double.Parse(match.Value);
                    damage += currentNum;

                }

                var modifiers = demon
                    .Where(s => s == '*' || s == '/');

                foreach (var modifier in modifiers)
                {
                    if (modifier == '*')
                    {
                        damage *= 2;
                    }
                    else
                    {
                        damage /= 2;
                    }
                }

                result.Add(demon, new Demon
                {
                    Health = health,
                    Damage = damage,
                    Name = demon,
                });


            }
            foreach (var demonEntry in result)
            {
                var demonNow = demonEntry.Value;
                Console.WriteLine($"{demonNow.Name} - {demonNow.Health} health, {demonNow.Damage:F2} damage ");
            }
        }
    }
}
