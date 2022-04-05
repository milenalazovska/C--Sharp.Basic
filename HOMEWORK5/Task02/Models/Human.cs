namespace Task02.Models
{
    public class Human
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int Age { get; set; }

        public Human(string firstName, string lastName, int Age)
        {
            firstName = firstName;
            lastName = lastName;
            Age = Age;
        }

        public string GetPersonStats()
        {
            return $"{firstName} {lastName} is {Age} old. ";
        }
    }
}

