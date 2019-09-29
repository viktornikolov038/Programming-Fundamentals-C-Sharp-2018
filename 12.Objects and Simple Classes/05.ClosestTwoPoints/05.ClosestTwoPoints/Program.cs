using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ClosestTwoPoints
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                var currentPoint = ReadPoint();
                points.Add(currentPoint);
            }

            var minDistance = double.MaxValue;
            Point firstPointResult = null;
            Point secondPointResult = null;

            for (int first = 0; first < points.Count; first++)
            {
                for (int second = first + 1; second < points.Count; second++)
                {
                    var firstPoint = points[first];
                    var secondPoint = points[second];
                    var distance = Distance(firstPoint,secondPoint);

                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        firstPointResult = firstPoint;
                        secondPointResult = secondPoint;
                    }
                }
            }
            Console.WriteLine("{0:F3}",minDistance);
            Console.WriteLine($"({firstPointResult.X},{firstPointResult.Y})");
            Console.WriteLine($"({secondPointResult.X},{secondPointResult.Y})");

        }


        public static double Distance(Point firstPoint, Point secondPoint)
        {
            var squareX = Math.Pow(firstPoint.X - secondPoint.X, 2);
            var squareY = Math.Pow(firstPoint.Y - secondPoint.Y, 2);
            var distance = Math.Sqrt(squareX + squareY);
            return distance;
        }

        public static Point ReadPoint()
        {
            var readPoint = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            return new Point
            {
                X = readPoint[0],
                Y = readPoint[1]
            };
        }
    }
}
