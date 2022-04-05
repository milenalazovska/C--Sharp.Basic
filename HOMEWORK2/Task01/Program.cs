using System;

namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create new console application “RealCalculator” that takes two
            //numbers from the input and asks what operation would the user want to be done( +, - , * , / ).
            //Then it returns the result.
            //* Test Data:
            // *Enter the First number: 10
            // * Enter the Second number: 15
            // * Enter the Operation: +
            //*Expected Output:
            // *The result is: 25

            Console.WriteLine("Enter a number");
            string firstNumber = Console.ReadLine();

            Console.WriteLine("Enter another number");
            string secondNumber = Console.ReadLine();

            Console.WriteLine("Choose one operation +, -, *, / ");
            string operationChoose = Console.ReadLine();

            int parsedFirstNumber = int.Parse(firstNumber);
            int parsedSecondNumber = int.Parse(secondNumber);
            char parsedOperation = char.Parse(operationChoose);


            if (parsedOperation == '*')
            {
                int total = parsedFirstNumber * parsedSecondNumber;
                Console.WriteLine(total);
            }
            if (parsedOperation == '+')
            {
                int sum = parsedFirstNumber + parsedSecondNumber;
                Console.WriteLine(sum);
            }
            if (parsedOperation == '-')
            {
                int minus = parsedFirstNumber - parsedSecondNumber;
                Console.WriteLine(minus);
            }
            if (parsedOperation == '/')
            {
                int divide = parsedFirstNumber / parsedSecondNumber;
                Console.WriteLine(divide);

            }
        }
    }
}
