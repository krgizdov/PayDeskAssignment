namespace MarketStoreSystem.Cards
{
    using System;
    public abstract class Card : ICard
    {
        private string owner;
        private decimal turnover;
        public Card(string owner, decimal turnover, decimal initialDiscountRate = 0)
        {
            this.Owner = owner;
            this.Turnover = turnover;
            this.DiscountRate = initialDiscountRate;
        }
        public string Owner
        {
            get => this.owner;

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ErrorConstants.NAME_IS_NULL_OR_EMPTY);
                }
                this.owner = value;
            }
        }

        public decimal Turnover
        {
            get => this.turnover;

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ErrorConstants.TURNOVER_IS_NEGATIVE);
                }
                this.turnover = value;
            }
        }

        public decimal DiscountRate { get; protected set; }

        protected abstract void CalculateDiscountRate(decimal turnover);
    }
}
