using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public class EducationalSubscription : ISubscription
    {
        public decimal MonthlyFee { get; } = 5.99m;
        public int MinPeriod { get; } = 3;
        public string[] Channels { get; } = { "Documentaries", "Science", "History" };

        public void ShowDetails()
        {
            System.Console.WriteLine("Premium Subscription: $" + MonthlyFee + "/month, Min Period: " + MinPeriod + " month.\n Channels: " + string.Join(", ", Channels));
        }
    }
}
