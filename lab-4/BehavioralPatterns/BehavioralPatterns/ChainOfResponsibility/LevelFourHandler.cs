using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ChainOfResponsibility
{
    public class LevelFourHandler : SupportHandler
    {
        public override bool HandleRequest(string userInput)
        {
            if (userInput == "4")
            {
                Console.WriteLine("Підключення до служби критичних звернень (Рівень 4).");
                return true;
            }
            return base.HandleRequest(userInput);
        }
    }
}
