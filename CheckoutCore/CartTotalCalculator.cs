using System.Collections.Generic;
using System.Linq;
using CheckoutCore.Model;

namespace CheckoutCore
{
    public class CartTotalCalculator
    {
        List<PriceInfo> prices;

        public CartTotalCalculator(List<PriceInfo> prices)
        {
            this.prices = prices;
        }

        public decimal GetTotal(Dictionary<string, int> items)
        {
            var total = 0M;

            foreach (var item in items)
            {
                total += GetTotalForItem(item);
            }

            return total;
        }

        public decimal GetTotalForItem(KeyValuePair<string, int> item)
        {
            var priceInfo = prices.FirstOrDefault(p => p.SKU == item.Key);
            if (priceInfo == null) return 0;

            var offer = priceInfo.SpecialOffer;
            decimal total;
            if (offer != null)
            {
                total = (item.Value / offer.Quantity) * offer.Price + (item.Value % offer.Quantity) * priceInfo.UnitPrice;
            }
            else
            {
                total = item.Value * priceInfo.UnitPrice;
            }
            return total;
        }
    }
}
