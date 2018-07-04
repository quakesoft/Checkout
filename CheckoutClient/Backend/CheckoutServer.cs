using System.Collections.Generic;
using CheckoutClient.CheckoutServiceReference;

namespace CheckoutClient.Backend
{
    class CheckoutServer : ServiceStub
    {
        public decimal Checkout(Dictionary<string, int> items)
        {
            using (var c = new ServiceClient())
            {
                return c.CalculateTotals(items);
            }
        }
    }
}
