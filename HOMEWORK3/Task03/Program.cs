using System;

namespace Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Task 3
               Ask the user to enter a number as an input.Print all the numbers except the numbers divisible by 5.
               When you come to 80, the limit is reached.*/

            Console.WriteLine("Enter a number smaller than 80");
            bool number = int.TryParse(Console.ReadLine(), out int parsedNumber);
            if (number)
            {
                for (int i = parsedNumber; i < 80; i++)
                {
                    if (i < 80 && i % 5 != 0)
                    {
                        Console.WriteLine($"{i}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
