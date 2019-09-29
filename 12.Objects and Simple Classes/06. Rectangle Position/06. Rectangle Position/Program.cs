using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rectangle_Position
{
    class Program
    {
        public static void Main()
        {
            var firstReactangle = ReadRectangle();
            var secondReactangle = ReadRectangle();

            var result = firstReactangle.IsInside(secondReactangle);
            if (result)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }

        public static Rectangle ReadRectangle()
        {
            var reactangle = new Rectangle();
            var reactangleProps = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            return new Rectangle()
            {
                Left = reactangleProps[0],
                Top = reactangleProps[1],
                Width = reactangleProps[2],
                Height = reactangleProps[3]
            };
        }

        
    }
}
