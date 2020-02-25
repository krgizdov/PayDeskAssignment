namespace MarketStoreSystem
{
    using MarketStoreSystem.Cards;
    using System;
    public class Program
    {
        static void Main()
        {
            try
            {
                var bronzeCard = new BronzeCard("George", 0);
                var silverCard = new SilverCard("Jenny", 600);
                var goldCard = new GoldCard("Peter", 1500);

                PayDesk.CalculatePurchaseInfo(bronzeCard, 150);
                PayDesk.CalculatePurchaseInfo(silverCard, 850);
                PayDesk.CalculatePurchaseInfo(goldCard, 1300);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
