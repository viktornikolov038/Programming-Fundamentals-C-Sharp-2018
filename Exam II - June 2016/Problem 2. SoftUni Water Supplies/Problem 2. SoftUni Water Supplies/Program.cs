using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.SoftUni_Water_Supplies
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalAmountOfWater = int.Parse(Console.ReadLine());
            var untouchedAmountOfWater = totalAmountOfWater;
            var bottles = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var capacityForEachBottle = int.Parse(Console.ReadLine());
            var bottlesFilled = 0;

            var leftBottles = new List<int>();
            for (int i = 0; i < bottles.Length; i++)
            {
                leftBottles.Add(i);
            }
            
            if (totalAmountOfWater % 2 == 0)
            {
                for (int i = 0; i < bottles.Length; i++)
                {
                    var currentBottle = bottles[i];
                    totalAmountOfWater -= capacityForEachBottle - currentBottle;
                    bottlesFilled++;
                    leftBottles.Reverse();
                    leftBottles.Remove(i);
                    if (totalAmountOfWater < 0)
                    {
                        bottlesFilled--;
                        leftBottles.Add(i);
                        
                        Console.WriteLine("We need more water!");
                        Console.WriteLine($"Bottles left: {bottles.Length - bottlesFilled}");
                        var kit = (bottles.Length * capacityForEachBottle) - untouchedAmountOfWater;
                        Console.WriteLine($"With indexes: {string.Join(", ", leftBottles)}");
                        Console.WriteLine($"We need {kit} more liters!");
                        break;
                    }
                }
            }
            else
            {
                for (int i = bottles.Length - 1; i >= 0; i--)
                {
                    var currentBottle = bottles[i];
                    totalAmountOfWater -= capacityForEachBottle - currentBottle;
                    bottlesFilled++;
                    leftBottles.Reverse();
                    leftBottles.Remove(i);
                    if (totalAmountOfWater < 0)
                    {
                        bottlesFilled--;
                        leftBottles.Add(i);
                        leftBottles.Reverse();
                        Console.WriteLine("We need more water!");
                        Console.WriteLine($"Bottles left: {bottles.Length - bottlesFilled}");
                        var kit = (bottles.Length * capacityForEachBottle) - untouchedAmountOfWater;
                        Console.WriteLine($"With indexes: {string.Join(", ",leftBottles)}");
                        Console.WriteLine($"We need {kit} more liters!");
                        break;
                    }
                }
            }
            if (totalAmountOfWater >= 0)
            {
                Console.WriteLine("Enough water!");
                Console.WriteLine($"Water left: {totalAmountOfWater}l.");
            }

        }
    }
}
