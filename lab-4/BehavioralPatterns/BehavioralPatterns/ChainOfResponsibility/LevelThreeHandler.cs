using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ChainOfResponsibility
{
    public class LevelThreeHandler : SupportHandler
    {
        public override bool HandleRequest(string userInput)
        {
            if (userInput == "3")
            {
                Console.WriteLine("Підключення до фінансової підтримки (Рівень 3).");
                return true;
            }
            return base.HandleRequest(userInput);
        }
    }
}
