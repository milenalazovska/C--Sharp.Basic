using System;

namespace Task05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Task 5
               *Create an array of integers. Get the number of elements and the values of the elements from input.
               * Find how many times there are two 3 next to each other.
             *Example: 
              *Enter number of elements: 7
              * Enter first element: 9
              * Enter second element: 3
              * Enter first element: 3
              * Enter first element: 4
              * Enter first element: 3
              * Enter first element: 3
              * Enter first element: 3
              * Three times there are threes next to each other.*/

            Console.WriteLine("Enter the number of element");
            int numberOfElements = int.Parse(Console.ReadLine());


            int[] arrayOfNumbers = new int[numberOfElements];
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                Console.WriteLine($"Enter a value for index: {i}");
                bool success = int.TryParse(Console.ReadLine(), out int numbers);
                if (!success)
                {
                    throw new Exception($"Invalid input for index: {i}");
                }

                arrayOfNumbers[i] = numbers;


            }
            int counter = 0;
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {

                if (arrayOfNumbers[i] == 3 && arrayOfNumbers[i - 1] == 3)
                {
                    counter++;
                }
              
            }
            Console.WriteLine(counter);
        }
            
     
    }
 }







