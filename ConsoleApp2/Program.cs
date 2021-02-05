using System;

namespace ConsoleApp2
{
    public class Drawing
    {
        public virtual double Area()
        {
            return 0;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Drawing circle = new Circle();
            Console.WriteLine("Area of the circle: " + circle.Area());

            Drawing square = new Square();
            Console.WriteLine("Area of the Square: " + square.Area());

            string result = "";
            double Pi = Math.PI;
            double Radius = Math.Round(circle.Area() / Pi);
            double Length = Math.Round(Math.Sqrt(square.Area()));

            if (Radius < (Length / 2))
            {
                result = "The Circle fits into the Square";
            }

            if (Length < (2 * Radius))
            {
                result = "The Square fits into the Circle";
              
            }
            Console.WriteLine(result);
        }
    }
}
