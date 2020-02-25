namespace MarketStoreSystem.Cards
{
    using System;
    public class GoldCard : Card
    {
        private const decimal INITIAL_DISCOUNT_RATE = 2;
        private const decimal TURNOVER_REQUIREMENT = 100;
        private const decimal MAX_BONUS_DISCOUNT_RATE = 8;

        public GoldCard(string owner, decimal turnover)
            : base(owner, turnover, INITIAL_DISCOUNT_RATE)
        {
            this.CalculateDiscountRate(turnover);
        }

        protected override void CalculateDiscountRate(decimal turnover)
        {
            if (turnover >= TURNOVER_REQUIREMENT)
            {
                decimal turnoverIncrease = Math.Floor(turnover / TURNOVER_REQUIREMENT);

                this.DiscountRate +=
                    turnoverIncrease > MAX_BONUS_DISCOUNT_RATE ? MAX_BONUS_DISCOUNT_RATE : turnoverIncrease;
            }
        }
    }
}
