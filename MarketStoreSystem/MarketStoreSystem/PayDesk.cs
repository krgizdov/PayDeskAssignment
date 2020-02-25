namespace MarketStoreSystem
{
    using MarketStoreSystem.Cards;
    using System;
    using System.Text;
    public static class PayDesk
    {
        public static void CalculatePurchaseInfo(Card card, decimal purchaseValue)
        {
            if (purchaseValue < 0)
            {
                throw new ArgumentException(ErrorConstants.PURCHASE_VALUE_IS_NEGATIVE);
            }

            decimal discountValue = (card.DiscountRate / 100) * purchaseValue;
            decimal totalPrice = purchaseValue - discountValue;

            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Card type: {card.GetType().Name}");
            builder.AppendLine($"Purchase value: ${purchaseValue:f2}");
            builder.AppendLine($"Discount rate: {card.DiscountRate:f1}%");
            builder.AppendLine($"Discount: ${discountValue:f2}");
            builder.AppendLine($"Total: ${totalPrice:f2}");

            Console.WriteLine(builder);
        }
    }
}
