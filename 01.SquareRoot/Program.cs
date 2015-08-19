using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SquareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            //Write a program that reads an integer number and calculates and prints its square root.
            //If the number is invalid or negative, print Invalid number.
            //In all cases finally print Good bye.
            //Use try-catch-finally block.

            try
            {
                Console.WriteLine("Enter number: ");
                int a = int.Parse(Console.ReadLine());

                if (a < 0)
                {
                    throw new ArgumentException();
                }

                double result = Math.Sqrt(a);
                Console.WriteLine("Result = {0}", result);
            }

            catch
            {
                Console.WriteLine("Invalid number!");
            }

            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
