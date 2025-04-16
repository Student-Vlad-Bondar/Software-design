using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Mediator
{
    public class CommandCentre
    {
        private List<Runway> _runways;
        private Dictionary<Aircraft, Runway> _landingMapping;

        public CommandCentre(Runway[] runways)
        {
            _runways = new List<Runway>(runways);
            _landingMapping = new Dictionary<Aircraft, Runway>();
        }

        public void Land(Aircraft aircraft)
        {
            Console.WriteLine($"Aircraft {aircraft.Name} is requesting landing.");
            Runway freeRunway = _runways.FirstOrDefault(r => !r.IsBusy);
            if (freeRunway != null)
            {
                freeRunway.IsBusy = true;
                _landingMapping.Add(aircraft, freeRunway);
                freeRunway.HighlightRed();
                Console.WriteLine($"Aircraft {aircraft.Name} has landed on runway {freeRunway.Id}.");
            }
            else
            {
                Console.WriteLine($"No available runway for Aircraft {aircraft.Name} to land.");
            }
        }

        public void TakeOff(Aircraft aircraft)
        {
            Console.WriteLine($"Aircraft {aircraft.Name} is requesting takeoff.");
            if (_landingMapping.ContainsKey(aircraft))
            {
                Runway runway = _landingMapping[aircraft];
                runway.IsBusy = false;
                runway.HighlightGreen();
                Console.WriteLine($"Aircraft {aircraft.Name} has taken off from runway {runway.Id}.");
                _landingMapping.Remove(aircraft);
            }
            else
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is not on any runway.");
            }
        }
    }
}
