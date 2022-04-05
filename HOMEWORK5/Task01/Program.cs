using System;

namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Task 1
           Make a method called AgeCalculator
           The method will have one input parameter, your birthday date
           The method should return your age
           Show the age of a user after he inputs a date
           Note: take into consideration if the birthday is today, after or before today*/

         Console.WriteLine("Enter your birthday");
         string myBirthday = (Console.ReadLine());
         DateTime parsedBirthday = DateTime.Parse(myBirthday);
         Console.WriteLine(parsedBirthday);

         AgeCalculator(parsedBirthday); 
         void AgeCalculator(DateTime birthday)
            {
             DateTime currentTime = DateTime.Today;
             int currentYear = currentTime.Year;
             int currentMonth = currentTime.Month;
             int currentDay = currentTime.Day;
                
             int myYear = birthday.Year;
             int myMonth = birthday.Month;
             int myDay = birthday.Day;
            
                if (currentMonth < myMonth)
                {
                   int myAge = (currentYear - myYear) - 1;
                   Console.WriteLine($"Your age is: {myAge}");
                }
                if(currentMonth > myMonth)
                {
                    int myAge = (currentYear - myYear);
                    Console.WriteLine($"Your age is:{myAge}");
                }
                if(currentMonth == myMonth && currentDay > myDay)
                {
                    int myAge = (currentYear - myYear) - 1;
                    Console.WriteLine($"Your age is: {myAge}, soon is your birthday");
                }
                if(currentMonth == myMonth && currentDay < myDay)
                {
                    int myAge = (currentYear - myYear);
                    Console.WriteLine($"Your age is: {myAge}");
                }
                if(currentMonth == myMonth && currentDay == myDay)
                {
                    int myAge = (currentYear - myYear);
                    Console.WriteLine($"Today is your birthday!!! You are {myAge} old.");
                }
            
            }    

        }
    }
}
