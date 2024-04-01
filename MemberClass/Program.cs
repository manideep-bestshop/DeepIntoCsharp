using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberClass
{
    
        class Car
        {
            private string CName;
            public void GetData()
            {
                CName = "Car";
            }
            public void Display()
            {
                Console.WriteLine(CName);
                //   s.CallFromOutmethod();

            }
            public class Sterio   //member class
            {
                private string SName;
                Car c = new Car();   //main class instance
                public void GetInfo()
                {
                    c.GetData();
                    SName = "Sterio";
                }
                public void show()
                {
                    c.Display();
                    Console.WriteLine(SName);
                }
                public void CallFromOutmethod()
                {
                    Console.WriteLine("output from member class and calling from main class");
                }
            }
            // Sterio s=new Sterio();  // instance craeted in class 
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                //  Car c=new Car();
                Car.Sterio s = new Car.Sterio();

                //c.GetData();
                s.GetInfo();

                //c.Display();
                s.show();
            }
        }
    }
