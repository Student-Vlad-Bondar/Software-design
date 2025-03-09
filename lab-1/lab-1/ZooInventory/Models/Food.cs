using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Models
{
    public class Food
    {
        public string Name { get; set; }
        public double Quantity { get; set; }

        public Food(string name, double quantity)
        {
            Name = name;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"{Name} - {Quantity}";
        }
    }
}
