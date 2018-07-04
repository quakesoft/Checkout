public class PriceInfo
{
    public string SKU { get; set; }
    public string Description { get; set; }
    public decimal UnitPrice { get; set; }
    public Offer SpecialOffer { get; set; }
}

public class Offer
{
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}