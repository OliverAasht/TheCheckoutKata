using TheCheckoutKata.Exceptions;
using TheCheckoutKata.Pricing;

namespace TheCheckoutKata.CheckoutItems
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
                    throw new PricingRuleNotFoundException(item.Key);

                // does the item a special pricing rule? if so, is the quantity is enough to apply it
                if (rule.SpecialQuantity.HasValue && item.Value >= rule.SpecialQuantity.Value)
                {
                    // calculate how many times the special offer can be applied
                    int specialSets = item.Value / rule.SpecialQuantity.Value;

                    // calculate if there is a remainder that doesn't qualify for the special offer
                    int remainder = item.Value % rule.SpecialQuantity.Value;

                    // add the price for the special offers to the total price
                    totalPrice += specialSets * (rule.SpecialPrice ?? 0);

                    // add the price for the remaining items at the normal unit price
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
