namespace SalespersonDemo
{
    public class RealEstateSalesperson : Salesperson, ISellable
    {
        public double TotalValueSold { get; set; }
        public double TotalCommissionEarned { get; set; }
        public double CommissionRate { get; set; }

        public RealEstateSalesperson(string firstName, string lastName, double commissionRate)
            : base(firstName, lastName)
        {
            CommissionRate = commissionRate;
        }

        public override void SalesSpeech()
        {
            Console.WriteLine("I am a real estate agent. Let me help you find your dream home!");
        }

        public void MakeSale(int houseValue)
        {
            TotalValueSold += houseValue;
            TotalCommissionEarned += houseValue * CommissionRate;
        }
    }
}

