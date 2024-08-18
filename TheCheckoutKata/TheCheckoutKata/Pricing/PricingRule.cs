namespace TheCheckoutKata.Pricing
{
    public record PricingRule(
       string SKU,
       int UnitPrice,
       int? SpecialQuantity = null,
       int? SpecialPrice = null
    );
}
