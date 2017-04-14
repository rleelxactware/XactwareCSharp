using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15___Methods
{
    class FibonacciSecuence
    {
        public static void Main(string[] args)

        {
            Console.WriteLine("What number (between 1 and 10) in the Fibonacci Sequence would you like to find?");
            String numbEntered = Console.ReadLine();
            double number = Convert.ToDouble(numbEntered);

            Console.WriteLine($"The sequence number {number} correlates to  Fibonacci number {Testing(number)}.");

            Console.ReadKey();
        }

        private static double Testing(double number)
        {
            if (number < 3)
                return 1;
            return Testing(number - 1) + Testing(number - 2);

        }
    }
}
