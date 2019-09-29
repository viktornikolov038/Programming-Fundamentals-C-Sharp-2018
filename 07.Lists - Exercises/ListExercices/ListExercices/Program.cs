using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercices
{
    class Program
    {
        public static void Main()
        {
            //var line = Console.ReadLine()
            //    .Split()
            //    .ToList();
            //var result = new List<string>();
            //for (int i = 0; i < line.Count; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        result.Add(line[i]);
            //    }
            //}
            //Console.WriteLine(string.Join("",result));

            //var blackList = Console.ReadLine().Split();
            //var track = Console.ReadLine();
            //var result = new List<string>();
            //while (track != "end")
            //{
            //    var isInBlackList = false;
            //    foreach (var word in blackList)
            //    {
            //        if (track.Contains(word))
            //        {
            //            isInBlackList = true;
            //            break;
            //        }
            //    }
            //    if (!isInBlackList)
            //    {
            //        result.Add(track);
            //    }
            //    track = Console.ReadLine();

            //}
            //result.Sort();
            //foreach (var song in result)
            //{
            //    Console.WriteLine(song);
            //}


            //3.	Equal Sum After Extraction
            var firstLine = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            var secondLine = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            foreach (var number in firstLine)
            {
                if (secondLine.Contains(number))
                {
                    secondLine.Remove(number);
                }
            }
            if (firstLine.Sum() == secondLine.Sum())
            {
                Console.WriteLine("Yes. Sum: {0}",firstLine.Sum());
            }
            else
            {
                Console.WriteLine("No. Diff: {0}", Math.Abs(firstLine.Sum() - secondLine.Sum()));
            }
        }
    }
}
