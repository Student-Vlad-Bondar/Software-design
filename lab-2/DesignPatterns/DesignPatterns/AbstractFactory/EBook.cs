﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class EBook : IDevice
    {
        public string Model { get; private set; }
        public EBook(string model)
        {
            Model = model;
        }
        public void ShowSpecs()
        {
            System.Console.WriteLine($"EBook Model: {Model}");
        }
    }
}
