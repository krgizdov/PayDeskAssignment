namespace MarketStoreSystem.Cards
{
    public class BronzeCard : Card
    {
        private const decimal LOW_DISCOUNT_RATE_REQUIREMENT = 100;
        private const decimal HIGH_DISCOUNT_RATE_REQUIREMENT = 300;
        private const decimal LOW_DISCOUNT_RATE = 1;
        private const decimal HIGH_DISCOUNT_RATE = 2.5M;
        
        public BronzeCard(string owner, decimal turnover)
             : base(owner, turnover)
        {
            this.CalculateDiscountRate(turnover);
        }

        protected override void CalculateDiscountRate(decimal turnover)
        {
            if (turnover >= LOW_DISCOUNT_RATE_REQUIREMENT && turnover <= HIGH_DISCOUNT_RATE_REQUIREMENT)
            {
                this.DiscountRate = LOW_DISCOUNT_RATE;
            }
            else if (turnover > HIGH_DISCOUNT_RATE_REQUIREMENT)
            {
                this.DiscountRate = HIGH_DISCOUNT_RATE;
            }
        }
    }
}
