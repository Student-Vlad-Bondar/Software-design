using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    public class Virus : ICloneable
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public List<Virus> Children { get; set; } = new List<Virus>();

        public Virus(string name, string type, int age, double weight)
        {
            Name = name;
            Type = type;
            Age = age;
            Weight = weight;
        }

        public object Clone()
        {
            return DeepClone();
        }

        public Virus DeepClone()
        {
            Virus clone = (Virus)this.MemberwiseClone();
            clone.Children = new List<Virus>();
            foreach (var child in this.Children)
            {
                clone.Children.Add(child.DeepClone());
            }
            return clone;
        }

        public void Display(string indent = "")
        {
            Console.WriteLine($"{indent}Virus: {Name}, Type: {Type}, Age: {Age}, Weight: {Weight}");
            foreach (var child in Children)
            {
                child.Display(indent + "  ");
            }
        }
    }
}
