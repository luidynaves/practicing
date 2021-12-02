using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopifyDiscount
{
    class Program
    {
        static decimal POPCORN_PRICE = 7;
        static decimal SODA_PRICE = 2.5m;
        static decimal DISCOUNT = 0.5m;

        static void Main(string[] args)
        {
            Console.WriteLine("Shopify Coding Challenge!");

            Console.WriteLine($"Total: {Tally(new string[] { "2021-01-04,popcorn","2021-01-04,soda","2021-02-01,soda","2021-02-01,soda","2021-02-01,popcorn" })}");

            Console.ReadLine();
        }

        static decimal Tally(string[] orders)
        {
            var amountOrders = new Dictionary<string, Tuple<decimal, int, int>>();

            foreach (var order in orders)
            {
                string[] orderRow = order.Split(',');
                decimal currentPrice = 0;
                int popcornQuantity = 0;
                int sodaQuantity = 0;

                if (orderRow[1] == "popcorn")
                {
                    currentPrice = POPCORN_PRICE;
                    popcornQuantity++;
                }
                else if (orderRow[1] == "soda")
                {
                    currentPrice = SODA_PRICE;
                    sodaQuantity++;
                }

                if (amountOrders.ContainsKey(orderRow[0]))
                {
                    var dateAmount = amountOrders[orderRow[0]];
                    currentPrice += dateAmount.Item1;
                    popcornQuantity += dateAmount.Item2;
                    sodaQuantity += dateAmount.Item3;

                    if (orderRow[1] == "popcorn")
                    {               
                        if (sodaQuantity > 0)
                        {
                            currentPrice -= DISCOUNT;
                            sodaQuantity--;
                            popcornQuantity--;
                        }
                    }
                    else if (orderRow[1] == "soda")
                    {                     
                        if (popcornQuantity > 0)
                        {
                            currentPrice -= DISCOUNT;
                            popcornQuantity--;
                            sodaQuantity--;
                        }
                    }

                    amountOrders[orderRow[0]] = new Tuple<decimal, int, int>(currentPrice, popcornQuantity, sodaQuantity);
                    continue;
                }

                amountOrders.Add(orderRow[0], new Tuple<decimal, int, int>(currentPrice, popcornQuantity, sodaQuantity));
            }

            return amountOrders.Sum(x => x.Value.Item1);
        }
    }
   
}
