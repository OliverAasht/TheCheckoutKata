namespace TheCheckoutKata
{
    public record PricingRule(
       string SKU,
       int UnitPrice,
       int? SpecialQuantity = null,
       int? SpecialPrice = null
    );
}
