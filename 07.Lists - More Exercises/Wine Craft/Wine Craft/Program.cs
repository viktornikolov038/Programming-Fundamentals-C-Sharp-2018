using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wine_Craft
{
    class Program
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                var mustInsert = Console.ReadLine();
                
                if (mustInsert == "end")
                {
                    break;
                }
                var number = int.Parse(mustInsert);
                var index = Convert.ToInt32(number.ToString().Substring(0, 1)); //vzima 1voto chislo ot golqmo chislo
                inputList.Insert(index, number);
                
            }

            Console.WriteLine(string.Join(" ",inputList));
        }
    }
}
