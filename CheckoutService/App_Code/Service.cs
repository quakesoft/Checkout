using System.Collections.Generic;
using System.IO;
using System.Web;
using CheckoutCore;
using CheckoutCore.Model;
using Newtonsoft.Json;

public class Service : IService
{
    public decimal CalculateTotals(Dictionary<string, int> items)
    {
        var prices = GetPrices();

        return new CartTotalCalculator(prices).GetTotal(items);
    }

    private static List<PriceInfo> GetPrices()
    {
        var path = Path.Combine(HttpRuntime.AppDomainAppPath, "stockPrices.json");
        var json = File.ReadAllText(path);
        return JsonConvert.DeserializeObject<List<PriceInfo>>(json);
    }
}
