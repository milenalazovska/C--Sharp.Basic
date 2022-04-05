using System;

namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //Take one string from the input and print its last 5 characters.

            Console.WriteLine("Input string here");
            string input = Console.ReadLine();
            string lastFiveCharacters = input.Substring(input.Length - 5);
            Console.WriteLine(lastFiveCharacters);
                        
        }
    }
}
