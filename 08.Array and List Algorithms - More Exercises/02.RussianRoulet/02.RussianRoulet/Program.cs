using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RussianRoulet
{
    class Program
    {
        static void Main(string[] args)
        {
            var cylinder = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var playersInput = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
            bool alive = true;
            int currentIndex = 0;
            int player = 0;
            while(alive)
            {
                string[] commandParams = playersInput[player].Split(',');
                var power = int.Parse(commandParams[0]);
                var direction = commandParams[1];
                switch (direction)
                {
                    case "Right":
                        currentIndex = (currentIndex + power) % 6;
                        if (cylinder[currentIndex] == 1)
                        {
                            Console.WriteLine("Game over! Player {0} is dead.",player);
                            return;
                        }
                        else
                        {
                            alive = true;
                        }
                        break;
                    case "Left":
                        currentIndex = Math.Abs(currentIndex - power) % 6;
                        if (cylinder[currentIndex] == 1)
                        {
                            Console.WriteLine("Game over! Player {0} is dead.", player);
                            return;
                        }
                        else
                        {
                            alive = true;
                        }
                        break;
                    default:
                        break;
                }
                player++;
            }
            if (alive)
            {
                Console.WriteLine("Everybody got lucky!");
            }
        }
    }
}
