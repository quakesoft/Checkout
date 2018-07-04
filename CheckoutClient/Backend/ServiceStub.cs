using System.Collections.Generic;

namespace CheckoutClient.Backend
{
    public interface ServiceStub
    {
        decimal Checkout(Dictionary<string, int> items);
    }
}
