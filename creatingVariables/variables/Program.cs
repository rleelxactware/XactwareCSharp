using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 2;

            b = a;
            a = -3;

            Console.WriteLine("Variable a = " + a);
            Console.WriteLine("Variable b = " + b);
            Console.WriteLine("\r\nPress any key to continue ...");
            
            Console.ReadKey();
        }
    }
}
