using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Inventory;
using Zoo.Models;
using ZooInventory.Inventory;
using ZooInventory.Models;


namespace ZooTests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Запуск тестів...\n");

            //Перевірка створення тварин через IAnimal
            IAnimal lion = new Mammal("Лев", 5);
            if (lion.Name == "Лев" && lion.Age == 5)
                Console.WriteLine("TestAnimalCreation Passed");
            else
                Console.WriteLine("TestAnimalCreation Failed");

            Console.Write("TestAnimalSound Output: ");
            lion.MakeSound();

            //Перевірка InventoryManager
            IInventoryManager inventoryManager = new InventoryManager();
            inventoryManager.AddAnimal(lion);
            inventoryManager.AddEmployee(new Employee("Іван Іванов", "Доглядач"));
            inventoryManager.AddEnclosure(new Enclosure("Вольєр", 8));
            inventoryManager.AddFood(new Food("М'ясо", 30));

            Console.WriteLine("\nInventoryManager Test Output:");
            inventoryManager.DisplayInventory();

            Console.WriteLine("Тести завершено. Натисніть будь-яку клавішу для виходу.");
            Console.ReadKey();
        }
    }
}
