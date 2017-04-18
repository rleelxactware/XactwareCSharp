using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_12___Looping
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Welcome to the tree program!\nPlease enter the number of rows you want you tree: ");
            string rowsEntered = Console.ReadLine();
            int numOfRows = Convert.ToInt32(rowsEntered);
            Console.WriteLine();
            Console.WriteLine();

            for (int row = 0; row < numOfRows; row ++)
            {
                for (int spaces = 1; spaces < numOfRows - row; spaces++)
                {
                    Console.Write(" ");
                }
                for ( int num = 0; num < row * 2 + 1; num++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //Printing out a tree
            /*
            Console.WriteLine("This program will print out a tree in astrisk's. Hit enter to continue");
            Console.ReadKey();
            for (int row = 0; row < 5; row++)
            {
                for (int spaces = 5; spaces > row + 1; spaces--)
                {
                    Console.Write(" ");
                }
                for (int num = 0; num < row * 2 + 1; num++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            */

            //FizzBuss PROGRAM

            //for (int num = 1; num <= 100; num++)
            //{
            //    if (num % 3 == 0 && num % 5 == 0)
            //    {
            //        Console.Write("FizzBuzz ");
            //    }
            //    else if (num % 3 == 0)
            //    {
            //        Console.Write("Fizz ");
            //    }
            //    else if (num % 5 == 0)
            //    {
            //        Console.Write("Buzz ");
            //    }
            //    else
            //    {
            //        Console.Write($"{num} ");
            //    }
            //}



            Console.ReadKey();
        }
    }
}
