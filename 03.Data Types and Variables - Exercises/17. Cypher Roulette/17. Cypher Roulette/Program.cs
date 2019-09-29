using System;

namespace DataTypesExercises
{
    class Exercises
    {
        static void Main()
        {
            var wordsCount = int.Parse(Console.ReadLine());
            var output = string.Empty;
            var previousWord = string.Empty;
            var addToTheEnd = true;
            for (int i = 0; i < wordsCount; i++)
            {
                var currentWord = Console.ReadLine();
                if (currentWord == "spin")
                {
                    addToTheEnd = !addToTheEnd;
                    i--;
                }               
                if (addToTheEnd)
                {
                    output += currentWord;
                }
                else
                {
                    output = currentWord + output;
                }

                if (currentWord == previousWord)
                {
                    output = string.Empty;
                    if (currentWord == "spin")
                    {
                        addToTheEnd = !addToTheEnd;
                    }
                    previousWord = currentWord;
                }

                previousWord = currentWord;
            }
            output = output.Replace("spin", string.Empty);
            Console.WriteLine(output);
        }
    }
}