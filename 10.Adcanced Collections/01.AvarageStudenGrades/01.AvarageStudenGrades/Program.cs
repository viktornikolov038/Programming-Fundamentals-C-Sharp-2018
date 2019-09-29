using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AvarageStudenGrades
{
    class Program
    {
        public static void Main()
        {
            var loop = int.Parse(Console.ReadLine());
            var grades = new Dictionary<string, List<double>>();
            for (int i = 0; i < loop; i++)
            {
                var tokens = Console.ReadLine().Split(' ');
                var name = tokens[0];
                var grade = double.Parse(tokens[1]);
                if (!grades.ContainsKey(name))
                {
                    grades[name] = new List<double>();
                }
                grades[name].Add(grade);
            }

            foreach (var nameAndGrade in grades)
            {
                Console.WriteLine("{0} -> {1} (avg: {2:f2})",
                    nameAndGrade.Key,
                    string.Join(" ", nameAndGrade.Value.Select(p => string.Format("{0:f2}",p))),
                    nameAndGrade.Value.Average());
            }
        }
    }
}
