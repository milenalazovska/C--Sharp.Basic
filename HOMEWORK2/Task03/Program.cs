using System;

namespace Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //## Task 3:
            //Create new console application “SwapNumbers”. Input 2 numbers from the console and then swap the values of the 
            //variables so that the first variable has the second value and the second variable the first value.
            //Please find example below:
            //*Test Data:
            //*Input the First Number: 5
            //* Input the Second Number: 8
            //* Expected Output:
            //*After Swapping:
            //*First Number: 8
            //* Second Number: 5

            Console.WriteLine("Enter your first number");
            bool firstNumber = int.TryParse(Console.ReadLine(), out int firstParsedNumber);

            Console.WriteLine("Enter your second number");
            bool secondNumber = int.TryParse(Console.ReadLine(), out int secondParsedNumber);

            if(firstNumber && secondNumber)
            {
                int temp = firstParsedNumber;
                firstParsedNumber = secondParsedNumber;
                secondParsedNumber = temp;
                Console.WriteLine($"Now your first number is:{firstParsedNumber} and your second number is:{secondParsedNumber}");
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }
    }
}
