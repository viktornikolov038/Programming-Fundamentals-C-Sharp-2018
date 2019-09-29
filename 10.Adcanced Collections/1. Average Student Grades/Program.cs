using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Average_Student_Grades
{
    class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var result = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                var parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var name = parameters[0];
                var grade = double.Parse(parameters[1]);
                if (!result.ContainsKey(name))
                {
                    result[name] = new List<double>();
                }
                result[name].Add(grade);
            }

            foreach (var student in result)
            {
                Console.WriteLine("{0} -> {1} (avg: {2:F2})",
                    student.Key,
                    string.Join(" ", student.Value.Select(p => string.Format("{0:f2}", p))),
                    student.Value.Average());
            }
        }
    }
}
