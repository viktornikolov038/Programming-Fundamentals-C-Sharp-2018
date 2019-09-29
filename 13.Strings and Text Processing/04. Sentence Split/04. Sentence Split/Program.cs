using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sentence_Split
{
    class Program
    {
        public static void Main()
        {
            var sentance = Console.ReadLine();
            var delimer = Console.ReadLine().ToArray();
            for (int i = 0; i < length; i++)
            {
            var kur = sentance.Split(new[] { delimer[i] });
           
        }
    }
}
