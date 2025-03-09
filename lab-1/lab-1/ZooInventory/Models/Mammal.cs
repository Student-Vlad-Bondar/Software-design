using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Models
{
    public class Mammal : Animal
    {
        public Mammal(string name, int age) : base(name, age) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} ричить!");
        }
    }
}
