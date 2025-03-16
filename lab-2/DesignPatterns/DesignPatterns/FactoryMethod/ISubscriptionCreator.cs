using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public interface ISubscriptionCreator
    {
        ISubscription CreateSubscription();
    }
}
