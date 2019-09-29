using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_1
{
    public class Program
    {
        public static void Main()
        {
            var fileContent = File.ReadAllLines("../../Program.cs");

            
            
            
            File.AppendAllLines("../../copiedProgram.cs",fileContent);
        }
    }
}
