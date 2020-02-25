namespace MarketStoreSystem.Cards
{
    public interface ICard
    {
        string Owner { get; }

        decimal Turnover { get; }

        decimal DiscountRate { get; }
    }
}
