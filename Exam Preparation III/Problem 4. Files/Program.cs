using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Files
{
    class Program
    {
        public static void Main()
        {
            var result = new Dictionary<string, Dictionary<string,string>>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var inputParams = Console.ReadLine()
                    .Split('\\');
                var currentQuery = inputParams[0];
                var fileFullPath = inputParams[inputParams.Length - 1];
                var fileTokens = fileFullPath.Split(';');
                var fileName = fileTokens[0];
                var fileSize = fileTokens[1];

                
                if (!result.ContainsKey(currentQuery))
                {
                    result[currentQuery] = new Dictionary<string, string>();
                }
                result[currentQuery].Add(fileName, fileSize);
            }


            var commandProps = Console.ReadLine().Split(' ');
            var fileExtention = 
            
        }
    }
}
