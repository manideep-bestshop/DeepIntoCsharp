using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersEx
{
    public class AccessSpecifier
    {
        //Public field
        public int publicField;

        //Private field
        private int privateField;

        //Protected field
        protected int protectedField;

        //Internal field
        internal int internalField;

        //Constructor
        public AccessSpecifier()
        {
            publicField = 10;   // within same class we can access any access specifier
            privateField = 20;
            protectedField = 30;
            internalField = 40;
        }
        //Public method
        public void PublicMethod()
        {
            Console.WriteLine("This is a public method");
        }
        //Private method
        private void PrivateMethod()
        {
            Console.WriteLine("This is from private method");
        }
        //Protecetd method
        protected void protectedMethod()
        {
            Console.WriteLine("This is from protected method");
        }
        //Internal method
        internal void internalMethod()
        {
            Console.WriteLine("This is from internal method");
        }
    }
    //Derived class from AccessSpecifier
    public class DerivedClass : AccessSpecifier
    {
        public void AccessProtecetdMember()
        {
            //Protected members are accessible in derived classes
            protectedField = 50;
            protectedMethod();


        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            AccessSpecifier example = new AccessSpecifier();

            //Accessing public members
            Console.WriteLine("Public Field {0}", example.publicField);
            example.PublicMethod();

            // Private member is not accessible outside the class
            // Console.WriteLine(example.privateField); this line would cause a CTE
            // example.PrivateMethod(); this line would cause a CTE

            // Protected member is not accessible outside the class or its derived classes
            // Console.WriteLine(example.protectedField); this line would cause a CTE
            // example.ProtectedMethod(); this line would cause a CTE

            //Accessing internal member
            Console.WriteLine("Internal Field: " + example.internalField);
            example.internalMethod();

            Console.ReadLine();
        }
    }
}
