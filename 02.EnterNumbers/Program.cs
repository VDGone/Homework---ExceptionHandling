using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EnterNumbers
{
    class EnterNumbers
    {
        static void Main(string[] args)
        {
            //Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
            //If an invalid number or non-number text is entered, the method should throw an exception.
            //Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

            Console.WriteLine("Enter 10 numbers between 1 and 50: ");
            int[] numbers = new int[10];
            int start = 1;
            int end = 50;

            for (int i = 0; i < numbers.Length; i++) 
            {
                    Console.WriteLine("Number {0} = ", i + 1);
                    numbers[i] = ReadNumber(start, end);
            }
            Array.Sort(numbers);
            Console.WriteLine("Your numbers: {0}", string.Join(",", numbers));
        }

        static int ReadNumber(int start, int end)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < start || number > end)
                {
                    throw new ArgumentOutOfRangeException("Number must be in given range!");
                }
                return number;
            }
            catch (FormatException)
            {
                throw new FormatException("Not a Integer!");
            }
        }
    }
}
