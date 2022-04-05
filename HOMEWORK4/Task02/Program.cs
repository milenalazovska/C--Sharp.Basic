using System;

namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 2
            //Take a sentence as input and find its words.

            Console.WriteLine("Enter a sentence here");
            string sentence = Console.ReadLine();
            string[] splitString = sentence.Split(' ');
            foreach (string line in splitString)
            {
                Console.WriteLine(line);
            };
            
        }
    }
}
