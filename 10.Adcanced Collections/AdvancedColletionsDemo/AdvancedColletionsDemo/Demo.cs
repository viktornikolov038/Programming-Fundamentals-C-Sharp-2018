using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedColletionsDemo
{
    class Demo
    {
        public static void Main()
        {
            //    var grades = new Dictionary<string, List<int>>();
            //    AddGrades(grades, "Ivan", 6);
            //    AddGrades(grades, "Pesho", 5);
            //    AddGrades(grades, "Ivan", 2);
            //    AddGrades(grades, "Pesho", 2);
            //    AddGrades(grades, "Kiro", 6);
            //    AddGrades(grades, "Kiro", 3);
            //    //PrintGrades(grades);
            //    foreach (var nameAndGrade in grades)
            //    {
            //        Console.WriteLine("{0} -> {1}",
            //            nameAndGrade.Key,
            //            string.Join(" ",nameAndGrade.Value));
            //    }

            //}

            //public static void PrintGrades(Dictionary<string, List<int>> grades)
            //{
            //    foreach (var name in grades.Keys)
            //    {
            //        Console.WriteLine(name);
            //        foreach (var grade in grades[name])
            //        {
            //            Console.WriteLine(grade);
            //        }
            //    }
            //}

            //public static void AddGrades(Dictionary<string, List<int>> grades, string name, int grade)
            //{
            //    if (!grades.ContainsKey(name))
            //    {
            //        grades[name] = new List<int>();
            //    }
            //    grades[name].Add(grade);
            //}



            var grades = new Dictionary<string, List<int>>();
            var input = Console.ReadLine().Split();
            var inputName = input[0];
            var inputGrade = int.Parse(input[1]);
            addGrade(grades, "Ivan", 5);
            addGrade(grades, "Ivan", 3);
            addGrade(grades, "Ivan", 6);
            addGrade(grades, "Ivan", 2);
            addGrade(grades, inputName, inputGrade);

            foreach (var nameAndGrade in grades)
            {
                Console.WriteLine("{0} grades : {1}",
                    nameAndGrade.Key,
                    string.Join(" ",nameAndGrade.Value));
            }

            foreach (var name in grades.Keys)
            {
                Console.WriteLine(name);
                foreach (var grade in grades[name])
                {
                    Console.WriteLine(grade);
                }
            }

        }

        public static void addGrade(Dictionary<string, List<int>> grades, string name, int grade)
        {
            if (!grades.ContainsKey(name))
            {
                grades[name] = new List<int>();
            }
            grades[name].Add(grade);
        }
    }
}
