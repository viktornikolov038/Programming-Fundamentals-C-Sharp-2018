using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Lab
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Length: ");
            double lenght = 0;
            lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = 0;
            width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = 0;
            height = double.Parse(Console.ReadLine());
            double Volume = (lenght + width + height) / 3.0;
            Console.WriteLine("Pyramid Volume: {0:F2}", height);

        }
    }
}
