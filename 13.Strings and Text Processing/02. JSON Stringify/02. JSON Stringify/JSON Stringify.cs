using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.JSON_Stringify
{
    class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int[] Grades { get; set; }
    }

    class Program
    {
        public static void Main()
        {
            var students = new List<Student>();
            var inputLine = Console.ReadLine();

            while (inputLine != "stringify")
            {
                var inputParams = inputLine.Split(new[] { ' ', ':', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);

                var studentName = inputParams[0];
                var studentAge = int.Parse(inputParams[1]);
                var studentGrades = inputParams.Skip(2).Select(int.Parse).ToArray();

                Student newStudent = new Student();

                newStudent.Name = studentName;
                newStudent.Age = studentAge;
                newStudent.Grades = studentGrades;

                students.Add(new Student());
                inputLine = Console.ReadLine();
            }

            string output = "";

            output += "[";
            for (int i = 0; i < students.Count; i++)
            {
                Student currentStudent = students[i];
                output += "{";

                output += "name:\"" + currentStudent.Name + "\"" + ",";
                output += "age:" + currentStudent.Age + ",";
                output += "grades:[" + string.Join(", ",currentStudent.Grades) + "]";
                output += "}";
                if (i < students.Count - 1)
                {
                    output += ",";
                }

            }


            output += "]";

        }
    }
}


