namespace TheCheckoutKata
{
    public class PricingRuleNotFoundException : Exception
    {
        public PricingRuleNotFoundException()
        {
        }

        public PricingRuleNotFoundException(string message)
            : base(message)
        {
        }

        public PricingRuleNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
