using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Ladybugs
    {
        public static void Main()
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var ladyBugsIndexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var command = Console.ReadLine();
            var field = new int[fieldSize];
            for (int i = 0; i < ladyBugsIndexes.Length; i++)
            {
                field[ladyBugsIndexes[i]] = 1;
            }

            while (command != "end")
            {
                var commandParams = command.Split();
                var ladybugIndex = int.Parse(commandParams[0]);
                var direction = commandParams[1];
                var flyLenght = int.Parse(commandParams[2]);
                if (direction == "right")
                {
                    field[ladybugIndex] = 0;
                    if (ladybugIndex + flyLenght > fieldSize)
                    {
                        break;
                    }
                    else
                    {
                        field[ladybugIndex + flyLenght] = 1;
                    }

                }
                else if(direction == "left")
                {
                    field[ladybugIndex] = 0;
                    if (ladybugIndex - flyLenght < 0)
                    {
                        break;
                    }
                    else
                    {
                        field[ladybugIndex - flyLenght] = 1;

                    }
                }


                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",field));


        }
    }
}
