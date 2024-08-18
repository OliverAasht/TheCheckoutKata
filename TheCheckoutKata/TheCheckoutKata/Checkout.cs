namespace TheCheckoutKata
{
    public class Checkout(PricingRules pricingRules) : ICheckout
    {
        public int GetTotalPrice()
        {
            throw new NotImplementedException();
        }

        public void Scan(string item)
        {
            throw new NotImplementedException();
        }
    }
}
