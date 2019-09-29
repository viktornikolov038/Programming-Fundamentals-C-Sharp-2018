using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_and_LINQ_Demo
{
    class LinqDemo
    {
        public static void Main()
        {
            var numbers = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 5 , 6
            };
            //var numbers = Console.ReadLine()
            //    .Split(' ')
            //    .Select(n => int.Parse(n))
            //    .ToList();
            //var sortedNumbers = numbers
            //    .OrderBy(num => num)
            //    //OrdedByDescending - v obraten red 
            //    .ToList();
            //Console.WriteLine(string.Join(" ",sortedNumbers));


            //var students = new Dictionary<string, int>
            //{
            //    ["Ivan"] = 2,
            //    ["Aleks"] = 6,
            //    ["Gosho"] = 3,
            //    ["Marti"] = 4,
            //    ["Bobolio"] = 5,
            //    ["Eti"] = 2,
            //    ["Ani"] = 4
            //};
            //students = students
            //    .OrderBy(st => st.Value)
            //    .ThenBy(st => st.Key)
            //    .ToDictionary(st => st.Key,st => st.Value);

            //foreach (var student in students)
            //{
            //    Console.WriteLine($"{student.Key} - {student.Value}");
            //}

            //var numbers = new List<int>
            //{
            //    1, 2, 3, 4, 5, 6, 7, 8, 9, 5 , 6
            //};
            //var firstThree = numbers
            //    .OrderByDescending(num => num)
            //    .Take(3)
            //    .OrderBy(num => num)
            //    .ToList();
            //var skipElement = numbers
            //    .OrderBy(num => num)
            //    .Skip(3)
            //    .Take(3)
            //    .ToList();

            //Console.WriteLine(string.Join(" ",firstThree));
            //Console.WriteLine(string.Join(" ", skipElement));






            //var odds = numbers
            //    .Where(n => n % 2 == 0)
            //    .ToList();
            //var smallerThanFive = numbers
            //    .Where(n => n < 5)
            //    .ToList();
            //var countSmallerThanFive = numbers
            //    .Count(n => n % 2 == 0);
            //Console.WriteLine("odds : " + string.Join(" ", odds));
            //Console.WriteLine("there are {0} odd numbers", countSmallerThanFive);
            //Console.WriteLine("smaller than five : " + string.Join(" ", smallerThanFive));
            //Console.WriteLine();





            //dali ima pone edno chislo po-golqmo ot 15
            //var hasNumbers = numbers             
            //    .Any(n => n > 15);

            //if (hasNumbers)
            //{
            //    Console.WriteLine("There are numbers!");
            //}
            //else
            //{
            //    Console.WriteLine("There arent numbers");
            //}


            //var biggerThanZeo = numbers
            //    .All(n => n > 0);
            //if (biggerThanZeo)
            //{
            //    Console.WriteLine("There are numbers!");
            //}
            //else
            //{
            //    Console.WriteLine("There arent numbers");
            //}

            var symbols = numbers
                .Select(n => n * 200)
                .ToList();
            var symbolsAsChar = numbers
                .Select(n => "NUmber :" + n);
            Console.WriteLine(string.Join(Environment.NewLine, symbolsAsChar));
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
