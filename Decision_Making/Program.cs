using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Making
{
    class Program
    {
        static void Main(string[] args)
        {

            //DETERMINING IF A NUMBER IS ODD OR EVEN
            //----------------------------------------------------------
            /*
            Console.WriteLine("Please enter a whole number: ");
            string numberEntered = Console.ReadLine();

            //convert string from read line to an int
            double number = Convert.ToDouble(numberEntered);
            double remander = number % 2;
            bool isEven;
            if(remander == 0)
            {
                isEven = true;
            }
            else
            {
                isEven = false;
            }


            if(isEven)
            {
                Console.WriteLine("Your number is an even number!!!");
            }
            else
            {
                Console.WriteLine("Your number is odd!!!");
            }
            Console.ReadLine();
            */


            //POSITIVE OR NEGATIVE NUMBER AFTER MUTIPLICATION
            //------------------------------------------------------
            /*
            Console.WriteLine("\nAfter you enter two numbers, \nwe will determine if the result after multiplication is a positive or negative number!!\n\n");

            Console.WriteLine("Please enter one number, positive or negative.");
            string numOneEntered = Console.ReadLine();
            double numOne = Convert.ToDouble(numOneEntered);

            Console.WriteLine("\nPlease enter another number, positive or negative.");
            string numTwoEntered = Console.ReadLine();
            double numTwo = Convert.ToDouble(numTwoEntered);
            

            if(numOne < 0 && numTwo < 0)
            {
                Console.WriteLine("\nAfter multipliplication your number will be positive!");
            }
            else if(numOne > 0 && numTwo > 0)
            {
                Console.WriteLine("\nAfter multipliplication your number will be positive!");
            }
            else
            {
                Console.WriteLine("\nAfter multipliplication your number will be negative!");
            }
            Console.ReadLine();
            */


            //POSITIVE OR NEGATIVE NUMBER AFTER MUTIPLICATION USING TERNARY OPERATOR
            //------------------------------------------------------
            Console.WriteLine("\nAfter you enter two numbers," +
                "\nwe will determine if the result after multiplication is a positive or negative number!!\n\n");

            Console.WriteLine("Please enter one number, positive or negative.");
            string numOneEntered = Console.ReadLine();
            double numOne = Convert.ToDouble(numOneEntered);

            Console.WriteLine("Please enter another number, positive or negative.");
            string numTwoEntered = Console.ReadLine();
            double numTwo = Convert.ToDouble(numTwoEntered);

            Console.WriteLine((numOne < 0 && numTwo < 0) || (numOne > 0 && numTwo > 0) ?
                "\nYour number is Positive!!" : "\nYour number is Negative!!");

            Console.ReadLine();
        }
    }
}
