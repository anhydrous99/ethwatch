using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API_call;

namespace Trade_or_Not
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Trade_or_Not\n" + 
                          "  Grabbing Ethereum Price vs USD and vs BTC...");
            try
            {
                float usd_price = NanoPool.get_eth_usd_rate();
                float btc_price = NanoPool.get_eth_btc_rate();
                Console.WriteLine("    USD Price : " + usd_price.ToString());
                Console.WriteLine("    BTC Price : " + btc_price.ToString());
                Console.WriteLine("  Enter number pertaining to what you want to trade:");
                Console.WriteLine("1) ETH to USD to ETH\n" +
                                  "2) ETH to BTC to ETH\n" +
                                  "3) USD to ETH to USD\n" +
                                  "4) BTC to ETH to BTC");
                char Char = Console.ReadKey().KeyChar;
                if (Char == '1')
                {
                    do_Calculations("ETH", "USD", usd_price);
                }
                else if (Char == '2')
                {
                    do_Calculations("ETH", "BTC", btc_price);
                }
                else if (Char == '3')
                {
                    do_Calculations("USD", "ETH", 1 / usd_price);
                }
                else if (Char == '4')
                {
                    do_Calculations("BTC", "ETH", 1 / btc_price);
                }
                else
                {
                    Console.WriteLine("Error: Invalid Input\nExiting... ");
                    Environment.Exit(1);
                }
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("Exiting... ");
                Environment.Exit(1);
            }
        }
        static void do_Calculations(string from, string to, float Exchange_Rate)
        {
            float amount, pull, fee, returned, profit;
            Console.WriteLine("\n  Enter amount invested(" + from + "): ");
            amount = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("  Enter price you want to pull out: ");
            pull = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("  Enter fee(" + from + "): ");
            fee = Convert.ToSingle(Console.ReadLine());
            returned = ((amount - fee) * Exchange_Rate) * pull;
            profit = returned - amount;
            Console.WriteLine("  Return amount: " + returned + " " + from);
            Console.WriteLine("  Profit: " + profit);
        }
    }
}
