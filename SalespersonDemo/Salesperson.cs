namespace SalespersonDemo
{
    public abstract class Salesperson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Salesperson(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public abstract void SalesSpeech();
    }
}

