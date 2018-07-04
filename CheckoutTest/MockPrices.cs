using System.Collections.Generic;
using CheckoutCore.Model;

namespace CheckoutTest
{
    class MockPrices
    {
        public List<PriceInfo> GetMockPrices()
        {
            return new List<PriceInfo> {
                new PriceInfo
                {
                    SKU= "A99",
                    Description= "Apple",
                    UnitPrice= 0.50M,
                    SpecialOffer= new Offer {
                        Quantity= 3,
                        Price= 1.30M
                    }
                },
                new PriceInfo
                {
                    SKU= "B15",
                    Description= "Biscuits",
                    UnitPrice= 0.30M,
                    SpecialOffer= new Offer {
                        Quantity= 2,
                        Price= 0.45M
                    }
                },
                new PriceInfo
                {
                    SKU= "C40",
                    Description= "Coffee",
                    UnitPrice= 1.80M
                },
                new PriceInfo
                {
                    SKU= "T23",
                    Description= "Tissues",
                    UnitPrice= 0.99M
                }
            };
        }
    }
}
