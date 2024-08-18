namespace TheCheckoutKata
{
    public class Checkout(PricingRules pricingRules) : ICheckout
    {
        private Dictionary<string, int> items = new Dictionary<string, int>();

        public int GetTotalPrice()
        {
            throw new NotImplementedException();
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
