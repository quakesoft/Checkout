using System.Collections.Generic;
using System.Linq;
using CheckoutClient.Backend;

namespace CheckoutTest
{
    class MockService : ServiceStub
    {
        //MockService assumes each item is worth £1
        public decimal Checkout(Dictionary<string, int> items) => items.Values.Sum(v => v);
    }
}
