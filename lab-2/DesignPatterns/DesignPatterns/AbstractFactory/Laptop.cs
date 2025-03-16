using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class Laptop : IDevice
    {
        public string Model { get; private set; }
        public Laptop(string model)
        {
            Model = model;
        }
        public void ShowSpecs()
        {
            System.Console.WriteLine($"Laptop Model: {Model}");
        }
    }
}
