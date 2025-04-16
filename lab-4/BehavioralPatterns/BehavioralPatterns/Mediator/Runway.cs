using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Mediator
{
    public class Runway
    {
        public Guid Id { get; } = Guid.NewGuid();
        public bool IsBusy { get; set; }

        public void HighlightRed()
        {
            Console.WriteLine($"Runway {Id} is busy!");
        }

        public void HighlightGreen()
        {
            Console.WriteLine($"Runway {Id} is free!");
        }
    }
}
