using System.Collections.Generic;
using CheckoutClient;
using CheckoutCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckoutTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReplShouldCalculateBasketTotal()
        {
            var input = new MockInput();
            var service = new MockService();
            var repl = new REPL(input, service);

            var total = repl.Run();

            Assert.AreEqual(8M, total);
        }

        [TestMethod]
        public void ShouldCalculateTotalsPerItem()
        {
            var prices = new MockPrices().GetMockPrices();
            var calc = new CartTotalCalculator(prices);

            var total = calc.GetTotalForItem(new KeyValuePair<string, int>("A99", 4));

            Assert.AreEqual(1.80M, total);
        }

        [TestMethod]
        public void ShouldCalculateTotals()
        {
            var prices = new MockPrices().GetMockPrices();
            var calc = new CartTotalCalculator(prices);

            var total = calc.GetTotal(new Dictionary<string, int>
            {
                ["A99"] = 4,
                ["C40"] = 1
            });

            Assert.AreEqual(3.60M, total);
        }
    }
}
