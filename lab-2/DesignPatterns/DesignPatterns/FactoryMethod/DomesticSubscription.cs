using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public class DomesticSubscription : ISubscription
    {
        public decimal MonthlyFee { get; } = 9.99m;
        public int MinPeriod { get; } = 1;
        public string[] Channels { get; } = { "News", "Entertainment", "Sports" };

        public void ShowDetails()
        {
            System.Console.WriteLine("Premium Subscription: $" + MonthlyFee + "/month, Min Period: " + MinPeriod + " month.\n Channels: " + string.Join(", ", Channels));
        }
    }
}
