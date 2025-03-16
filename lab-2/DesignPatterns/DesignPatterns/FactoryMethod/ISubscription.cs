using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public interface ISubscription
    {
        decimal MonthlyFee { get; }
        int MinPeriod { get; }
        string[] Channels { get; }
        void ShowDetails();
    }
}
