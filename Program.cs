using System;
using System.Collections.Generic;

namespace stocks
{
    class Program
    {
        static void Main(string[] args)
        {
            // A block of publicly traded stock has a variety of attributes, we'll look at a few of them. A stock has a ticker symbol and a company name. Create a simple dictionary with ticker symbols and company names in the Main method.

            // Create dictionary with ticker and company names
            Dictionary<string, string> stocks = new Dictionary<string, string>(){
                {"GM", "General Motors"},
                {"CAT", "Caterpillar"},
                {"DE", "John Deere"},
                {"JPM", "JP Morgan"},
                {"MU", "Micron Technology"}
            };

            // Create dictionary with key: ticker and property: list of purchases
            Dictionary<string, List<double>> stockPurchases = new Dictionary<string, List<double>>(){
                {"GM", new List<double>(){5150.75, 3520.50, 4350.75}},
                {"CAT", new List<double>(){7120.25, 2150.50, 3230.20}},
                {"DE", new List<double>(){1740.75, 6450.60}},
                {"JPM", new List<double>(){6140.35, 3760.80}},
                {"MU", new List<double>(){2840.65, 5270.45}}
            };

            Console.WriteLine("Stock Ownership Report");
            Console.WriteLine("--------------------");

            // Loop through stockPurchases dictionary and print out total investment for that company
            foreach(KeyValuePair<string, List<double>> kvp in stockPurchases)
            {
                // Create variable to hold sum, loop through the value of each kvp in stockPurchases, which is a list of purchases, and add them up with the totalInvested variable
                double totalInvested = 0;
                foreach(double amount in kvp.Value)
                {
                    totalInvested += amount;
                }

                Console.WriteLine($"The position in {stocks[kvp.Key]} is worth ${totalInvested}.");
                
            }

        }
    }
}
