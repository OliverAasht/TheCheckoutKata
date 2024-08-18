namespace TheCheckoutKata
{
    public class PricingRules
    {
        private List<PricingRule> rules = new List<PricingRule>();

        public void AddRule(PricingRule rule)
        {
            rules.Add(rule);
        }

        public PricingRule GetRule(string sku)
        {
            return rules.First(x => x.SKU == sku);
        }
    }
}
