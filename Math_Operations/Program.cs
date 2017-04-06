using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int b = 5;
            int h = 6;
            double A = (b * h) / 2;

            int a = 17;
            int c = 4;
            int quotient = a / c;
            int remainder = a % c;
            int check = c * quotient + remainder;

            Console.WriteLine("The area of the triangle is " + A + ".");
            Console.WriteLine(a + "/" + c + " is " + quotient + " remainder " + remainder);
            Console.WriteLine(check + " = " + a);
            Console.WriteLine("\r\nPress any key to continue ...");
            */
            

            // CYLINDAR CALCULATOR
            
            Console.WriteLine("Welcome to cylindar Calculator!\n");

            Console.WriteLine("Please enter a value for the height of the cylinder: ");
            string heightUserEntered = Console.ReadLine();
            Console.WriteLine("Please enter a value for the radias of the base of the cylinder: ");
            string radiasUserEntered = Console.ReadLine();

            double height = Convert.ToDouble(heightUserEntered);
            double radias = Convert.ToDouble(radiasUserEntered);
            float pi = 3.1415926F;

            double volume = pi * (radias * radias) * height;
            double serfaceArea = 2 * pi * radias * (radias + height);

            Console.WriteLine("The volume of the cylinder is " + volume);
            Console.WriteLine("The Service Area of the cylindar is " + serfaceArea);


            Console.ReadKey();
            





            /*

            // CHAPTER 9 More Math
            short a = short.MaxValue;
            a += 1;
            short b = short.MinValue;
            Console.WriteLine($"Max + 1 = {a}, MinValiue = {b}");
            Console.ReadKey();
            */
        }
    }
}
