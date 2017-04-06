using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_Variable_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\r\nListing out all 13 types of variables!!\r\n");

            byte someByte = 15;
            short someShort = 16;
            int someInt = 17;
            long someLong = 18;
            sbyte someSbyte = 25;
            ushort someUshort = 26;
            uint someUint = 27;
            ulong someUlong = 28;
            char someChar = 'a';
            decimal someDecimal = 14.1m;
            float someFloat = 13.83F;
            double someDouble = 12.33;
            bool someBool = true;
            var someVar = "Testing var";
            string someString = "Testing string";

            Console.WriteLine(someByte);
            Console.WriteLine(someShort);
            Console.WriteLine(someInt);
            Console.WriteLine(someLong);
            Console.WriteLine(someSbyte);
            Console.WriteLine(someUshort);
            Console.WriteLine(someUint);
            Console.WriteLine(someUlong);
            Console.WriteLine(someChar);
            Console.WriteLine(someDecimal);
            Console.WriteLine(someFloat);
            Console.WriteLine(someDouble);
            Console.WriteLine(someBool);
            Console.WriteLine("\n\rPress any key to continue ...");

            Console.ReadKey();
        }
    }
}
