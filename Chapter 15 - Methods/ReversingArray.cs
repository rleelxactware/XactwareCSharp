using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15___Methods
{
//    class ReversingArray
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("This program will auto generate an array of ten intergers and then reverse the array!");
//            Console.WriteLine("Press any key to continue...\n");
//            Console.ReadKey();

//            int[] numbers = GenerateNumbers();

//            int[] newArray = Reverse(numbers);
//            PrintNumbers(numbers);
//            PrintNumbers(newArray);
//            Console.ReadKey();
//        }


//        private static void PrintNumbers(int[] numbers)
//        {
//            for (int index = 0; index < numbers.Length; index++)
//            {
//                Console.Write(numbers[index] + " ");
//            }
//            Console.WriteLine();
//        }


//        private static int[] Reverse(int[] numbers)
//        {
//            int[] newArray = new int[numbers.Length];

//            //PrintNumbers(numbers);

//            for (int index = 0; index < 10; index++)
//            {
//                newArray[index] = numbers[numbers.Length - index - 1];
//            }
//            /*
//            for (int index = 0; index < 10; index++)
//            {
//                numbers[index] = newArray[index];
//            }
//            */
//            return newArray;
//        }


//        private static int[] GenerateNumbers()
//        {
//            int min = 0;
//            int max = 100;
//            Random randNum = new Random();
//            int[] newArray = new int[10];
//            for (int index = 0; index < newArray.Length; index++)
//            {
//                newArray[index] = randNum.Next(min, max);
//            }
//            return newArray;
//        }
//    }
}
 
