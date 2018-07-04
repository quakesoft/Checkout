namespace CheckoutCore.Model
{
    public class PriceInfo
    {
        public string SKU { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public Offer SpecialOffer { get; set; }
    }
}
