using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoriesOfFields
{
    class Demo
    {
        public int i;
        public static int j;
        public const int k = 17;
        public readonly int m;
        public static readonly int n;

        static Demo()
        {
            Console.WriteLine(j + " " + k + " " + n);
            n += 40;
            Console.WriteLine(n);
        }
        public Demo()
        {
            Console.WriteLine(i + " " + j + " " + k + " " + m);
            m += 20;
            Console.WriteLine(m);
        }
        public void show()
        {
            Console.WriteLine(i + " " + j + " " + k + " " + m);
        }
        public static void display()
        {
            Console.WriteLine(j + " " + k);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            Console.WriteLine(d.i);
            Demo.j += 10;
            Console.WriteLine(Demo.j);
            d.show();
            Demo.display();
            Console.WriteLine(Demo.n);
        }
    }
}
