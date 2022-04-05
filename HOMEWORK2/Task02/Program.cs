using System;

namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.
         //*Test Data:
          // *Enter the First number: 10
          // * Enter the Second number: 15
           //* Enter the third number: 20
          // * Enter the four number: 30
        // * Expected Output:
          //  *The average of 10, 15, 20 and 30 is: 18

            Console.WriteLine("Enter your first number");
            bool firstNumber = int.TryParse(Console.ReadLine(), out int parsedFirstNumber);

            Console.WriteLine("Enter your second number");
            bool secondNumber = int.TryParse(Console.ReadLine(), out int parsedSecondNumber);

            Console.WriteLine("Enter your third number");
            bool thirdNumber = int.TryParse(Console.ReadLine(), out int parsedThirdNumber);

            Console.WriteLine("Enter your fourth number");
            bool fourthNumber = int.TryParse(Console.ReadLine(), out int parsedFourthNumber);

           
            if (firstNumber && secondNumber && thirdNumber && fourthNumber)
            {
                int sumOfNumbers = parsedFirstNumber + parsedSecondNumber + parsedThirdNumber + parsedFourthNumber;
                float resault = (float)(sumOfNumbers / 4.0);
                Console.WriteLine($" The resault is: {resault}");
            }
            else
            {

                Console.WriteLine("Invalid input");
            }


        }
    }
}
