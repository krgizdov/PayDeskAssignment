namespace MarketStoreSystem.Cards
{
    public class SilverCard : Card
    {
        private const decimal INITIAL_DISCOUNT_RATE = 2;
        private const decimal TURNOVER_REQUIREMENT = 300;
        private const decimal MAX_DISCOUNT_RATE = 3.5M;
        public SilverCard(string owner, decimal turnover)
            : base(owner, turnover, INITIAL_DISCOUNT_RATE)
        {
            this.CalculateDiscountRate(turnover);
        }

        protected override void CalculateDiscountRate(decimal turnover)
        {
            if (turnover > TURNOVER_REQUIREMENT)
            {
                this.DiscountRate = MAX_DISCOUNT_RATE;
            }
        }
    }
}
