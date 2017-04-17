using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_19___Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Player test1 = new Player();
            test1.Score=3;
            Console.WriteLine($"The score is {test1.Score}.");
            

            Ball ball1 = new Ball();
            ball1.Size = 15;
            ball1.TimesThrown = 10;
            Console.WriteLine($"The ball has been thrown {ball1.TimesThrown} times");
            Console.WriteLine($"The size of the ball is {ball1.Size}.");



            Console.ReadKey();
        }
    }
}
