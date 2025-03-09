using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public Employee(string name, string position = "Доглядач")
        {
            Name = name;
            Position = position;
        }

        public override string ToString()
        {
            return $"{Name} ({Position})";
        }
    }
}
