using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ChainOfResponsibility
{
    public class LevelTwoHandler : SupportHandler
    {
        public override bool HandleRequest(string userInput)
        {
            if (userInput == "2")
            {
                Console.WriteLine("Підключення до технічної підтримки (Рівень 2).");
                return true;
            }
            return base.HandleRequest(userInput);
        }
    }
}
