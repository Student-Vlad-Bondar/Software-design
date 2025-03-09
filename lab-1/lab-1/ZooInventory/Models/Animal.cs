using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooInventory.Models;

namespace Zoo.Models
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void MakeSound();
    }
}
