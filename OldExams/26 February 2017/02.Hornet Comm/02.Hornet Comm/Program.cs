using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Hornet_Comm
{
    public class PrivateMessage
    {
        public int firstQuery { get; set; }

        public string secondQuery { get; set; }
    }

    public class Broadcasts
    {
        public string firstQuery { get; set; }

        public string secondQuery { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "Hornet is Green")
                {
                    break;
                }
                var inputParams = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var firstQuery = inputParams[0];
                var secondQuery = inputParams[1];

                var digitsOfFirst = 0;
                if (int.TryParse(firstQuery,out digitsOfFirst))
                {

                }

            }
        }
    }
}
