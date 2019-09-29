using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Track_Downloader
{
    class Program
    {
        static void Main(string[] args)
        {
            var blacklist = Console.ReadLine()
                .Split()
                .ToList();
            var songs = Console.ReadLine();
            var result = new List<string>();

            while (songs != "end")
            {
                
                var isInBlackLiST = false;
                foreach (var word in blacklist)
                {
                    if (songs.Contains(word))
                    {
                        isInBlackLiST = true;
                        break;
                    }

                }
                if (!isInBlackLiST)
                {
                    result.Add(songs);
                }
                songs = Console.ReadLine();
            }
            result.Sort();

            var resultAsString = string.Join(Environment.NewLine, result);
            Console.WriteLine(resultAsString);

        }
    }
}
