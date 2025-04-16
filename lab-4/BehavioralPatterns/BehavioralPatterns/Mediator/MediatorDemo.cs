using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Mediator
{
    public class MediatorDemo
    {
        public static void Run()
        {
            Console.WriteLine("\n>> Mediator Demo:\n");

            Runway[] runways = new Runway[] { new Runway(), new Runway() };
            CommandCentre commandCentre = new CommandCentre(runways);
            Aircraft aircraft1 = new Aircraft("Boeing 777", commandCentre);
            Aircraft aircraft2 = new Aircraft("Airbus A380", commandCentre);

            aircraft1.RequestLanding();
            aircraft2.RequestLanding();
            aircraft1.RequestTakeOff();
            aircraft2.RequestTakeOff();
        }
    }
}
