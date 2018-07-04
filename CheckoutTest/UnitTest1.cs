using CheckoutClient;
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

            Assert.AreEqual(4.90M, total);
        }
    }
}
