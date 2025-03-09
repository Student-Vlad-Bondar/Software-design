using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Models;
using ZooInventory.Models;

namespace ZooInventory.Inventory
{
    public interface IInventoryManager
    {
        void AddAnimal(IAnimal animal);
        void AddEmployee(Employee employee);
        void AddEnclosure(Enclosure enclosure);
        void AddFood(Food food);
        void DisplayInventory();
    }
}
