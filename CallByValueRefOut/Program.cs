using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByValueRefOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;                        // actual or original parameters
            x = 10;
            y = 20;
            CByV(x, y);                     //call by value
            Console.WriteLine("After CallByValue " + x + "," + y);    // modifications in a and b are not reflecting here

            CByR(ref x, ref y);  //call by Ref
            Console.WriteLine("After CallByRef " + x + "," + y); // modifications in a and b are reflecting here

            x = 10;
            y = 20;
            int z = -6;
            CByO(ref x, ref y, out z);
            Console.WriteLine("Value of Z= " + z);

        }
        public static void CByV(int a, int b)  //recieving arguments/ formal arguments
        {
            Console.WriteLine(a + ", " + b);
            a = 100;
            b = 200;
        }

        public static void CByR(ref int a, ref int b)  //recieving arguments/ formal arguemnts
        {
            Console.WriteLine(a + ", " + b);
            a = 100;
            b = 200;
        }
        public static void CByO(ref int a, ref int b, out int c)   //recieving arguments/ formal arguemnts
        {
            Console.WriteLine(a + "," + b);
            // Console.WriteLine(c); we can not acess values
            c = a + b;
            Console.WriteLine(c);
        }
    }

}
