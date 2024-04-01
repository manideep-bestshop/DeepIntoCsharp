using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesOfClass
{
    internal class Program
    {
        class Demo
        {
            public int a, b, c; //fields or data members
        }

        class MethodDemo
        {
            public int a, b, c; //fields or data members
            public void show() //method or member function
            {
                a = 10;
                b = 12;
                c = a + b;
                Console.WriteLine("form method = " + c);
            }
        }

        class PrivateMembers
        {
            private int a, b, c; //private fields
            private void show() //private members
            {
                a = 10;
                b = 12;
                c = a + b;
                Console.WriteLine("Private method = " + c);
            }
            public void display()
            {
                show();       // call private method
                Console.WriteLine(a + " " + b + " " + c);
            }
        }
        static void Main(string[] args)
        {
            Demo d = new Demo();  // instance created for class i.e Object
            d.a = 1;
            d.b = 2;
            d.c = d.a + d.b;
            Console.WriteLine("without method= " + d.c);

            MethodDemo md = new MethodDemo();  //instance created for class i.e Object
            md.show();                     // message passing / method call

            PrivateMembers pm = new PrivateMembers();
            pm.display();  //calling private method using public method
        }
    }
}
