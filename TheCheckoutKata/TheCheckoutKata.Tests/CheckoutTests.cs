namespace TheCheckoutKata.Tests
{
    public class CheckoutTests
    {
        [Fact]
        public void GetTotalPriceReturnsExpectedValue()
        {
            // Arrange
            var pricingRules = new PricingRules();
            pricingRules.AddRule(new PricingRule("A", 50, 3, 130));
            pricingRules.AddRule(new PricingRule("B", 30, 2, 45));
            pricingRules.AddRule(new PricingRule("C", 20));
            pricingRules.AddRule(new PricingRule("D", 15));

            var checkout = new Checkout(pricingRules);
            checkout.Scan("A");
            checkout.Scan("B");
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("B");

            // Act
            var result = checkout.GetTotalPrice();

            // Assert
            Assert.Equal(175, result);
        }
    }
}