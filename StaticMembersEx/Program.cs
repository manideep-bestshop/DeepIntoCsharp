using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembersEx
{
    internal class Program
    {
        class demo
        {
            public static int i = 19;
            public int j = 25;
            public void Display()
            {
                Console.WriteLine("from display non static method of class demo.." + i + ".." + j);
            }
            public static void show()
            {
                Console.WriteLine("from static method of class demo " + i);
            }
            static demo()
            {
                Console.WriteLine("static constructor of class demo" + i);
            }
            public demo()
            {
                Console.WriteLine("Instance constructor of class demo" + i);
            }
        }
        static Program()
        {
            Console.WriteLine("From static constructor....");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("From Main method..");

            //  demo d= new demo(); 
            //demo d2=new demo();

            Console.WriteLine(demo.i);
            demo.show();
        }
    }
}
