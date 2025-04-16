using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ChainOfResponsibility
{
    public interface ISupportHandler
    {
        void SetNext(ISupportHandler nextHandler);
        bool HandleRequest(string userInput);
    }
}
