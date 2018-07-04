using CheckoutClient.Backend;
using CheckoutClient.Interaction;

namespace CheckoutClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new UserInput();
            var service = new CheckoutServer();
            new REPL(input, service).Run();
        }
    }
}
