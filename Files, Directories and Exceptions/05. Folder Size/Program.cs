using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Folder_Size
{
    public class Program
    {
        public static void Main()
        {
            var fileNames = Directory.GetFiles("../../TestFolder");

            var sumSize = 0.0;
            foreach (var file in fileNames)
            {
                var fileInfo = new FileInfo(file);
                sumSize += fileInfo.Length;
            }
            File.WriteAllText("../../output.txt", (sumSize / 1024 / 1024) + "");
        }
    }
}
