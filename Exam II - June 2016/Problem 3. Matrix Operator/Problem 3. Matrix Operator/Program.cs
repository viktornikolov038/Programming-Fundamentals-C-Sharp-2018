using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Matrix_Operator
{
    class Program
    {
        public static void Main()
        {
            var r = int.Parse(Console.ReadLine());
            var table = "";
            for (int i = 0; i < r; i++)
            {
                table += Console.ReadLine() + "|";
            }
            table = table.Remove(table.Length - 1);
            var rowsInTable = table.Split('|');
            
            
            
            while (true)
            {
                var command = Console.ReadLine();
                var commandParams = command.Split(' ');
                if (command == "end")
                {
                    break;
                }

                if (commandParams[0] == "remove")
                {
                    var removeType = commandParams[1];
                    var removePosition = 
                    Remove()
                }
                else if (commandParams[0] == "swap")
                {

                }
                else if (commandParams[0] == "insert")
                {

                }

            }

        }
    }
}
