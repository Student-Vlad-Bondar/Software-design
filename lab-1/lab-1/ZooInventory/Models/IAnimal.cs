using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooInventory.Models
{
    public interface IAnimal
    {
        string Name { get; set; }
        int Age { get; set; }
        void MakeSound();
    }
}
