using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Mediator
{
    public class Aircraft
    {
        public string Name { get; }
        public bool IsTakingOff { get; set; }
        private CommandCentre _mediator;

        public Aircraft(string name, CommandCentre mediator)
        {
            Name = name;
            _mediator = mediator;
        }

        public void RequestLanding()
        {
            _mediator.Land(this);
        }

        public void RequestTakeOff()
        {
            _mediator.TakeOff(this);
        }
    }
}
