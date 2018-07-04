using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using CheckoutClient.CheckoutServiceReference;

namespace CheckoutClient
{
    class REPL
    {
        Dictionary<string, int> items = new Dictionary<string, int>();

        public void Run()
        {
            while (true)
            {
                var skuIsValid = false;
                var sku = "";
                while (!skuIsValid)
                {
                    Console.WriteLine("Enter SKU or type checkout:");
                    sku = Console.ReadLine();
                    if (sku == "checkout")
                    {
                        using (var c = new ServiceClient())
                        {
                            var total = c.CalculateTotals(items);
                            Console.WriteLine($"The basket total is: {total}");
                        }
                        Console.ReadLine();
                        return;
                    }
                    skuIsValid = Regex.IsMatch(sku, @"[A-Z]\d{2}");
                    if (!skuIsValid) Console.WriteLine("SKU must be an uppercase letter followed by 2 digits.");
                }

                var qtyIsValid = false;
                var itemQty = "";
                var qty = 0;
                while (!qtyIsValid)
                {
                    Console.WriteLine("Enter quantity (1):");
                    itemQty = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(itemQty)) itemQty = "1";
                    qtyIsValid = Regex.IsMatch(itemQty, @"\d{1,4}");
                    if (!qtyIsValid) Console.WriteLine("Item quantity must be a number between 1 and 9999.");
                    else qty = Convert.ToInt32(itemQty);
                }

                items.Add(sku, qty);
            }
        }
    }
}
