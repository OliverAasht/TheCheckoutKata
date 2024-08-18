namespace TheCheckoutKata.Exceptions
{
    public class PricingRuleNotFoundException : Exception
    {
        public PricingRuleNotFoundException()
        {
        }

        public PricingRuleNotFoundException(string sku)
            : base($"Pricing rule not found for SKU: {sku}")
        {
        }

        public PricingRuleNotFoundException(string sku, Exception inner)
            : base($"Pricing rule not found for SKU: {sku}", inner)
        {
        }
    }
}
