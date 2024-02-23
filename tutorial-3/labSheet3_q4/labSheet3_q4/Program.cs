using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labSheet3_q4
{
    public abstract class Shape
    {
        public string ShapeType { get; set; }

        public abstract double Area { get; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape Type: {ShapeType}");
            Console.WriteLine($"Area: {Area}");
        }
    }

    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            ShapeType = "Rectangle";
            Length = length;
            Width = width;
        }

        public override double Area => Length * Width;
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            ShapeType = "Circle";
            Radius = radius;
        }

        public void SetRadius(double radius)
        {
            Radius = radius;
        }

        public override double Area => Math.PI * Math.Pow(Radius, 2);
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, 3);
            rectangle.DisplayShapeInfo();
            Console.WriteLine();

            Circle circle = new Circle(4);
            circle.DisplayShapeInfo();

            Console.ReadLine();
        }
    }
}
