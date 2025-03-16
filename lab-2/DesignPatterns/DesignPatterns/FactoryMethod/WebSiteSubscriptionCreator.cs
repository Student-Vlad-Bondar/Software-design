﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public class WebSiteSubscriptionCreator : ISubscriptionCreator
    {
        public ISubscription CreateSubscription()
        {
            return new PremiumSubscription();
        }
    }
}
