using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ChainOfResponsibility
{
    public class LevelOneHandler : SupportHandler
    {
        public override bool HandleRequest(string userInput)
        {
            if (userInput == "1")
            {
                Console.WriteLine("Підключення до служби загальних запитань (Рівень 1).");
                return true;
            }
            return base.HandleRequest(userInput);
        }
    }
}
