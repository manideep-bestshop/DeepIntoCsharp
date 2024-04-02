using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx
{
    public interface IShape
    {
        double Area();
    }

    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double Area()
        {
            return Width * Height;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Height = 15;
            rectangle.Width = 15;
            double result = rectangle.Area();

            Console.WriteLine(result);
        }
    }
}
