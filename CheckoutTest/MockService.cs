using System.Collections.Generic;
using CheckoutClient.Backend;

namespace CheckoutTest
{
    class MockService : ServiceStub
    {
        public decimal Checkout(Dictionary<string, int> items) => 4.9M;
    }
}
