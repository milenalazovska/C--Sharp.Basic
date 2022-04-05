
using System;
using Task02.Models;

namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Task 2
               Create a class Human
               Add properties: FirstName, LastName, Age
              Create a method called GetPersonStats that returns the full name of the human as well as their age
              Create an object human by asking the user to fill the required information
              (take first name,last name and age from user input)
              Call the GetPersonStats method and print the result in the console after the object is created*/

            
            Console.WriteLine("Enter your name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            Human human = new Human(firstName, lastName, age)
            {
                firstName = firstName,
                lastName = lastName,
                Age = age
            };
            
            Console.WriteLine(human.GetPersonStats());
         }
        
  }
}
