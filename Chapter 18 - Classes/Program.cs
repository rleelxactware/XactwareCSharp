using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18___Making_Your_Own_Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Ball ball1 = new Ball(28, new Color(255, 185, 18));
            Console.WriteLine($"Ball has been thrown {ball1.GetTimesThrown()} time.");
            ball1.Throw();
            ball1.Throw();
            Console.WriteLine($"Ball has been thrown {ball1.GetTimesThrown()} time.");
            ball1.Pop();
            ball1.Throw();

            Console.ReadKey();

        }
    }
}
