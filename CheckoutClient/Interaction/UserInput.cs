using System;

namespace CheckoutClient.Interaction
{
    class UserInput : Input
    {
        public string GetInput() => Console.ReadLine();
    }
}
