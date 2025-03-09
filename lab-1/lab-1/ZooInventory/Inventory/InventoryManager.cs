using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Models;
using ZooInventory.Inventory;
using ZooInventory.Models;

namespace Zoo.Inventory
{
    public class InventoryManager : IInventoryManager
    {
        private List<IAnimal> animals;
        private List<Employee> employees;
        private List<Enclosure> enclosures;
        private List<Food> foods;

        public InventoryManager()
        {
            animals = new List<IAnimal>();
            employees = new List<Employee>();
            enclosures = new List<Enclosure>();
            foods = new List<Food>();
        }

        public void AddAnimal(IAnimal animal) => animals.Add(animal);
        public void AddEmployee(Employee employee) => employees.Add(employee);
        public void AddEnclosure(Enclosure enclosure) => enclosures.Add(enclosure);
        public void AddFood(Food food) => foods.Add(food);

        public void DisplayInventory()
        {
            Console.WriteLine("=== Zoo Inventory ===\n");

            Console.WriteLine("Animals:");
            foreach (var animal in animals)
            {
                Console.WriteLine($"- {animal.Name}, Age: {animal.Age}");
            }
            Console.WriteLine();

            Console.WriteLine("Employees:");
            foreach (var emp in employees)
            {
                Console.WriteLine($"- {emp}");
            }
            Console.WriteLine();

            Console.WriteLine("Enclosures:");
            foreach (var enclosure in enclosures)
            {
                Console.WriteLine($"- {enclosure}");
            }
            Console.WriteLine();

            Console.WriteLine("Food:");
            foreach (var food in foods)
            {
                Console.WriteLine($"- {food}");
            }
            Console.WriteLine();
        }
    }
}
