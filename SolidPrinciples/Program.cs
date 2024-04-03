using System;
using System.IO;

namespace SolidPrinciples
{
    // SOLID Principle: Single Responsibility Principle (SRP)
    public class FileStorage
    {
        public void SaveToFile(string data, string filename)
        {
            File.WriteAllText(filename, data);
        }

        public string ReadFromFile(string filename)
        {
            return File.ReadAllText(filename);
        }
    }

    // SOLID Principle: Open/Closed Principle (OCP)
    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Rectangle : Shape
    {
        public double width;
        public double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double Area()
        {
            return width * height;
        }
    }

    public class Circle : Shape
    {
        public double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }
    }

    // SOLID Principle: Liskov Substitution Principle (LSP)
    public class AreaCalculator
    {
        public double CalculateArea(Shape shape)
        {
            return shape.Area();
        }
    }

    // SOLID Principle: Interface Segregation Principle (ISP)
    public interface IPrintable
    {
        void PrintInfo();
    }

    public class PrintableRectangle : Rectangle, IPrintable
    {
        public PrintableRectangle(double width, double height) : base(width, height) { }

        public void PrintInfo()
        {
            Console.WriteLine($"Rectangle with width {width} and height {height}");
        }
    }

    public class PrintableCircle : Circle, IPrintable
    {
        public PrintableCircle(double radius) : base(radius) { }

        public void PrintInfo()
        {
            Console.WriteLine($"Circle with radius {radius}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Demonstrate SRP
            var storage = new FileStorage();
            storage.SaveToFile("Hello, SOLID!", "test.txt");
            Console.WriteLine(storage.ReadFromFile("test.txt"));

            // Demonstrate OCP and LSP
            var rectangle = new Rectangle(5, 10);
            var circle = new Circle(5);
            var areaCalculator = new AreaCalculator();
            Console.WriteLine("Area of rectangle: " + areaCalculator.CalculateArea(rectangle));
            Console.WriteLine("Area of circle: " + areaCalculator.CalculateArea(circle));

            // Demonstrate ISP
            var printableRectangle = new PrintableRectangle(5, 10);
            var printableCircle = new PrintableCircle(5);
            printableRectangle.PrintInfo();
            printableCircle.PrintInfo();

        }
    }
}
