using CheckoutClient.Interaction;

namespace CheckoutTest
{
    class MockInput : Input
    {
        int i = 0;
        string[] responses = { "A99", "7", "C40", "", "checkout", "" };

        public string GetInput()
        {
            return responses[i++];
        }
    }
}
