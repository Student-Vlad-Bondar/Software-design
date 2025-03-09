using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zoo.Models
{
    public class Bird : Animal
    {
        public Bird(string name, int age) : base(name, age) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} співає!");
        }

    }
}
