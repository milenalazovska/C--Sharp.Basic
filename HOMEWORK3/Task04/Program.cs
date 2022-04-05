using System;

namespace Task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Task 4
              * Make a new console application.
              * Create an array of 10 whole numbers(integers). 
              *Find the minimum and maximum and print them in the console.*/

           int[] numbers = new int[10] { 10, 3, 4, 2, 5, 9, 7, 6, 8, 1 };
            int min = numbers[0];
            int max = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
              {
                  if(numbers[i] < min) { min = numbers[i]; }  
                  if(numbers[i] > max) { max = numbers[i]; }
              }

              Console.Write($"Maximum element is: { max}");
              Console.Write($"Minimum element is: { min}");

            
        }
    }
}
