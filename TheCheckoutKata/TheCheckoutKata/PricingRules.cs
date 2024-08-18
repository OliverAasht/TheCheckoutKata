namespace TheCheckoutKata
{
    public class PricingRules
    {
        private List<PricingRule> rules = new List<PricingRule>();

        public void AddRule(PricingRule rule)
        {
            rules.Add(rule);
        }

        public PricingRule? GetRule(string sku)
        {
            return rules.FirstOrDefault(x => x.SKU == sku);
        }
    }
}
