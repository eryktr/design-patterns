using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var strangeSquare = new StrangeSquare(2 * Math.Sqrt(2));
            IShape adaptedStrangeSquare = new SquareAdapter(strangeSquare);
            Console.WriteLine($"Area: {adaptedStrangeSquare.GetArea()}");
            Console.WriteLine($"Perimeter: {adaptedStrangeSquare.GetPerimeter()}");
            Console.ReadKey();
        }
    }
}
