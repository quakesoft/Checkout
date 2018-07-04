using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

public class Service : IService
{
    public decimal CalculateTotals(Dictionary<string, int> items)
    {
        var prices = GetPrices();

        var total = 0M;

        foreach (var item in items)
        {
            var priceInfo = prices.FirstOrDefault(p => p.SKU == item.Key);
            if (priceInfo == null) continue;

            var offer = priceInfo.SpecialOffer;
            if (offer != null)
            {
                total += (item.Value / offer.Quantity) * offer.Price + (item.Value % offer.Quantity) * priceInfo.UnitPrice;
            }
            else
            {
                total += item.Value * priceInfo.UnitPrice;
            }
        }

        return total;
    }

    private static List<PriceInfo> GetPrices()
    {
        var path = Path.Combine(HttpRuntime.AppDomainAppPath, "stockPrices.json");
        var json = File.ReadAllText(path);
        return JsonConvert.DeserializeObject<List<PriceInfo>>(json);
    }
}

