using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigningValuesForArguments
{
    class demo
    {
        private int i;
        private int j;
        private int k;

        public int show(int i, out int r, ref int p)
        {
            this.i = i;
            j = i + this.i;
            k = j + i + this.i;
            r = k;
            p = p + r + 10;

            return j;
        }
        public void GetInfo(int s, int t = 22)
        {
            Console.WriteLine("From getInfo Method");
            Console.WriteLine("s= " + s + "t= " + t);
        }
        public void GetVals(int r1, int r2)
        {
            Console.WriteLine("r1= " + r1 + "r2= ");
        }
        public void display()
        {
            Console.WriteLine("from display i= " + i);
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            int x = 18; //local variable

            demo d = new demo();
            int z;
            int m = 33;
            Console.WriteLine("Before call m= " + m);

            int y = d.show(x, out z, ref m);
            Console.WriteLine("after call m= " + m);
            Console.WriteLine("y= " + y);
            Console.WriteLine("z= " + z);

            //  Console.WriteLine( "y= "+d.show(x)); is called method cascading..

            d.display();
            d.GetInfo(11);
            d.GetInfo(66, 77);
            d.GetVals(r1: 11, r2: 22);
        }
    }
}
