using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public class PremiumSubscription : ISubscription
    {
        public decimal MonthlyFee { get; } = 14.99m;
        public int MinPeriod { get; } = 1;
        public string[] Channels { get; } = { "Movies", "Exclusive Shows", "Sports", "News" };

        public void ShowDetails()
        {
            System.Console.WriteLine("Premium Subscription: $" + MonthlyFee + "/month, Min Period: " + MinPeriod + " month.\n Channels: " + string.Join(", ", Channels));
        }
    }
}
