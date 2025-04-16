using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ChainOfResponsibility
{
    public abstract class SupportHandler : ISupportHandler
    {
        protected ISupportHandler NextHandler;

        public void SetNext(ISupportHandler nextHandler)
        {
            NextHandler = nextHandler;
        }

        public virtual bool HandleRequest(string userInput)
        {
            if (NextHandler != null)
                return NextHandler.HandleRequest(userInput);
            return false;
        }
    }
}
