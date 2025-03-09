using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Inventory;
using Zoo.Models;
using ZooInventory.Models;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryManager inventoryManager = new InventoryManager();

            IAnimal lion = new Mammal("Лев", 5);
            IAnimal elephant = new Mammal("Леопард", 4);
            IAnimal parrot = new Bird("Папуга", 2);

            var keeper1 = new Employee("Іван Іванов", "Доглядач");
            var keeper2 = new Employee("Петро Петренко", "Менеджер");

            var enclosure1 = new Enclosure("Африканський вольєр", 10);
            var enclosure2 = new Enclosure("Птаховий сад", 5);

            var meat = new Food("М'ясо", 50);
            var seeds = new Food("Насіння", 20);

            inventoryManager.AddAnimal(lion);
            inventoryManager.AddAnimal(elephant);
            inventoryManager.AddAnimal(parrot);

            inventoryManager.AddEmployee(keeper1);
            inventoryManager.AddEmployee(keeper2);

            inventoryManager.AddEnclosure(enclosure1);
            inventoryManager.AddEnclosure(enclosure2);

            inventoryManager.AddFood(meat);
            inventoryManager.AddFood(seeds);

            inventoryManager.DisplayInventory();

            Console.WriteLine("Демонстрація звуків тварин:");
            lion.MakeSound();
            elephant.MakeSound();
            parrot.MakeSound();

            Console.ReadKey();
        }
    }
}
