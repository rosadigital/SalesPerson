namespace SalespersonDemo
{
    public class GirlScout : Salesperson, ISellable
    {
        public int BoxesSold { get; set; }

        public GirlScout(string firstName, string lastName)
            : base(firstName, lastName)
        {
            BoxesSold = 0;
        }

        public override void SalesSpeech()
        {
            Console.WriteLine("Would you like to buy some delicious cookies? Support our cause!");
        }

        public void MakeSale(int boxesSold)
        {
            BoxesSold += boxesSold;
        }
    }
}

