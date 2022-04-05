using System;

namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
                      /*  ## Task 1
                  Create new console application “FindStatistics”. Input 2 numbers.If the two of them are even, print their sum,
                if one of them is odd, print their difference, if the two off them are odd, multiply them. Don't print just the result,
                but also the whole operation.Treat zero as even.
                Please find example below:
                  *Test Data:
               *Input the First Number: 8
               * Input the Second Number: 5
                  * Expected Output:
               *One of the numbers is odd.The operation and result are 8 - 5 = 3.
            */

            Console.WriteLine("Enter first number");
            bool firstNumber = int.TryParse(Console.ReadLine(), out int firstParsedNumber);

            Console.WriteLine("Enter second number");
            bool secondNumber = int.TryParse(Console.ReadLine(), out int secondParsedNumber);

            if(firstNumber && secondNumber)
            {
                if (firstParsedNumber % 2 == 0 && secondParsedNumber % 2 == 0)
                {
                    Console.WriteLine($"{firstParsedNumber} + {secondParsedNumber} = { firstParsedNumber + secondParsedNumber}");
                }
                else if (firstParsedNumber %2 != 0 && secondParsedNumber % 2 != 0)
                {
                    Console.WriteLine($"{firstParsedNumber} * {secondParsedNumber} = {firstParsedNumber * secondParsedNumber}");
                }
                else
                {
                    Console.WriteLine($"{firstParsedNumber} - {secondParsedNumber} = {firstParsedNumber - secondParsedNumber}");
                }

            }
            else
            {
                Console.WriteLine("Invalid number");
            }

        }
    }
}
