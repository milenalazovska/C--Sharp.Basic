using System;

namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
       /*Make a console application called SumOfEven. Inside it create an array of 6 integers.
       Find and print the sum of the even numbers from the array:
       *Test Data:
         *Enter integer no.1:
            *4
          * Enter integer no.1:
            *3
          * Enter integer no.1:
            *7
          * Enter integer no.1:
            *3
          * Enter integer no.1:
            *2
          * Enter integer no.1:
            *8
         * Expected Output:
          *The result is: 14*/

            int[] integerArray = new int [6];

            for (int i = 0; i < integerArray.Length; i++)
            {
                Console.WriteLine($"Enter a number for index:{i}");
                bool numbers = int.TryParse(Console.ReadLine(), out int number);
                if (numbers)
                {
                    integerArray[i] = number;
                }
                
              
            }
            int sumOfNumbers = 0;
            foreach (int item in integerArray)
            {
                if (item % 2 == 0)
                {
                    sumOfNumbers += item;
                }
            }

            Console.WriteLine($"The sum of the even numbers is:{sumOfNumbers}");
        }
    }
}
