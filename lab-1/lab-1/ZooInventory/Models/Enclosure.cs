using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Models
{
    public class Enclosure
    {
        public string Name { get; set; }
        public int Capacity { get; set; }

        public Enclosure(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
        }

        public override string ToString()
        {
            return $"{Name} (Вмістимість: {Capacity})";
        }
    }
}
