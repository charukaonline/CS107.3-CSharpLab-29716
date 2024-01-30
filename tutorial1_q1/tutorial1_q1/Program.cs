using System;

namespace RectangleAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the rectangle:");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the width of the rectangle:");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = CalculateArea(length, width);

            Console.WriteLine("The area of the rectangle is: " + area);
        }

        static double CalculateArea(double length, double width)
        {
            return length * width;
        }
    }
}
