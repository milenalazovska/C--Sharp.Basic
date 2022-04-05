using System;

namespace Task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 4
            //Create four methods for calculation sum, substract, multiplication and division of two numbers.
            //Create a function called calculator, that has three parameters.The first one is operator and then two numbers.
            //Depending on the value of the operator, call the corresponding function from the four ones from above.

            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter second number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a operation: +, -, *, /");
            string operation = Console.ReadLine();

            void Calculator(int num1, int num2, string operation)
            {
                if (operation == "+")
                {
                    int resault = Sum(num1, num2);

                    Console.WriteLine($"The sum is:{resault}");
                }
                if (operation == "-")
                {
                    int resault = Substract(num1, num2);
                    Console.WriteLine($"The resault is:{resault}");
                }
                if (operation == "/")
                {
                    int resault = Division(num1, num2);
                    Console.WriteLine($"The resault is:{resault}");
                }
                if (operation == "*")
                {
                    int resault = Multiplication(num1, num2);
                    Console.WriteLine($"The resault is:{resault}");
                }
            }



            static int Multiplication(int num1, int num2)
            {
                return num1 * num2;
            }

            static int Division(int num1, int num2)
            {
                return num1 / num2;
            }

            static int Substract(int num1, int num2)
            {
                return num1 - num2;
            }

            static int Sum(int num1, int num2)
            {
                return num1 + num2;
            }


            Calculator(num1,num2,operation);
        }
    }
}
            

         
    

