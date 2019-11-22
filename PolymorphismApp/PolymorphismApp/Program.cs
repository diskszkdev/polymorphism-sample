using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape shape = new Triangle(3, 3);
            Console.WriteLine($"三角形の面積: {shape.CalculateArea()}");

            shape = new Rectangle(3, 3);
            Console.WriteLine($"四角形の面積: {shape.CalculateArea()}");

            shape = new Circle(3);
            Console.WriteLine($"円の面積: {shape.CalculateArea()}");

            shape = new Trapezoid(3, 3, 3);
            Console.WriteLine($"台形の面積: {shape.CalculateArea()}");

            Console.ReadKey();
        }
    }
}