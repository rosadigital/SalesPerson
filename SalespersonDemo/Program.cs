namespace SalespersonDemo
{
    class Program
    {
        static void Main()
        {
            RealEstateSalesperson realEstateAgent = new RealEstateSalesperson("John", "Rosa", 0.05);
            realEstateAgent.SalesSpeech();
            realEstateAgent.MakeSale(200000);
            Console.WriteLine($"Real Estate Agent: {realEstateAgent.GetFullName()}");
            Console.WriteLine($"Total Value Sold: ${realEstateAgent.TotalValueSold}");
            Console.WriteLine($"Total Commission Earned: ${realEstateAgent.TotalCommissionEarned}");

            Console.WriteLine();

            GirlScout girlScout = new GirlScout("Emily", "Smith");
            girlScout.SalesSpeech();
            girlScout.MakeSale(50);
            Console.WriteLine($"Girl Scout: {girlScout.GetFullName()}");
            Console.WriteLine($"Boxes of Cookies Sold: {girlScout.BoxesSold}");
        }
    }
}