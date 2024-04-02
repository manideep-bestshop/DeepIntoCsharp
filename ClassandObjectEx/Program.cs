using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassandObjectEx
{
    // Class definition
    public class Car
    {
        // Fields
        public string Make;
        public string Model;
        public int Year;

        // Constructor
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        // Method
        public void Start()
        {
            Console.WriteLine("The car has started.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating objects
            Car car = new Car("Maruti","Swift",2014);
            car.Start();
        }
    }
}
