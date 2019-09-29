using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Rabbit_Hole
{
    class Program
    {
        static void Main(string[] args)
        {
            var commands = Console.ReadLine()
                .Split(' ')
                .ToList();
            int energy = int.Parse(Console.ReadLine());
            int currentIndex = 0;
            bool lastBomb = false;
            while (energy > 0)
            {
                string[] commandParams = commands[currentIndex].Split('|');
                var currentCommand = commandParams[0];
                lastBomb = false;
                if (currentCommand == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    break;
                }
                int value = int.Parse(commandParams[1]);
                switch (currentCommand)
                {
                    case "Left":
                        //left
                        currentIndex = Math.Abs(currentIndex - value) % commands.Count;
                        energy -= value;
                        break;
                    case "Right":
                        currentIndex = (currentIndex + value) % commands.Count;
                        energy -= value;
                        break;
                    case "Bomb":
                        commands.RemoveAt(currentIndex);
                        currentIndex = 0;
                        energy -= value;
                        lastBomb = true;
                        break;
                }

                if (commands[commands.Count - 1] != "RabbitHole")
                {
                    commands.RemoveAt(commands.Count - 1);
                }
                commands.Add("Bomb|" + energy);
            }
            if (lastBomb && energy <= 0)
            {
                Console.WriteLine("You are dead due to bomb explosion!");
            }
            else if (!lastBomb && energy <= 0)
            {
                Console.WriteLine("You are tired. You can't continue the mission.");
            }
        }
    }
}
