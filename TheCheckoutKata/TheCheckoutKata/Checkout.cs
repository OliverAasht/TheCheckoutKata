namespace TheCheckoutKata
{
    public class Checkout(PricingRules pricingRules) : ICheckout
    {
        private Dictionary<string, int> items = new Dictionary<string, int>();

        public int GetTotalPrice()
        {
            int totalPrice = 0;

            foreach (var item in items)
            {
                var rule = pricingRules.GetRule(item.Key);
                if (rule == null)
                    continue;

                if (rule.SpecialQuantity.HasValue && item.Value >= rule.SpecialQuantity.Value)
                {
                    int specialSets = item.Value / rule.SpecialQuantity.Value;
                    int remainder = item.Value % rule.SpecialQuantity.Value;

                    totalPrice += specialSets * rule.SpecialPrice.Value;
                    totalPrice += remainder * rule.UnitPrice;
                    continue;
                }

                totalPrice += item.Value * rule.UnitPrice;
            }

            return totalPrice;
        }

        public void Scan(string item)
        {
            if (items.ContainsKey(item))
            {
                items[item]++;
                return;
            }

            items[item] = 1;
        }
    }
}
