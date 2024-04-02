using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEx
{
    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public override double Area()
        {
            return Length * Width;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Length = 15;
            rectangle.Width = 15;
            double result=rectangle.Area();

            Console.WriteLine(result);
        }
    }
}
