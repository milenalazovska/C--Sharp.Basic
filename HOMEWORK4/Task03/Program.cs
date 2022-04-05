using System;

namespace Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 3
            //Create a function that takes a number as input.This method should return the sum of the digits in the number.
            Console.WriteLine("Enter a number with more than one digit");
            int n = int.Parse(Console.ReadLine());
            
                int m;
                int sum = 0;

                while (n > 0)
                {
                    m = n % 10;
                    sum = sum + m;
                    n = n / 10;
                }
                Console.Write("Sum is= " + sum);
            
           
            }
        }
    }


   
