using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class Netbook : IDevice
    {
        public string Model { get; private set; }
        public Netbook(string model)
        {
            Model = model;
        }
        public void ShowSpecs()
        {
            System.Console.WriteLine($"Netbook Model: {Model}");
        }
    }
}
