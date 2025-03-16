# Zoo Inventory System

This project is a simple zoo management system implemented in C#. It demonstrates key programming principles such as DRY, KISS, SOLID, YAGNI, Composition Over Inheritance, Program to Interfaces not Implementations, and Fail Fast. The system manages animals, employees, enclosures, and food items within a zoo environment.

---

## Project Structure

- **ZooInventory.Models**  
  Contains domain models and interfaces, e.g., the `IAnimal` interface.

- **Zoo.Models**  
  Contains classes representing zoo entities:
  - `Animal` (abstract class) – common properties for all animals.
  - `Mammal` and `Bird` – concrete implementations of animals.
  - `Employee` – represents zoo staff.
  - `Enclosure` – details about animal enclosures.
  - `Food` – information about food items.

- **Zoo.Inventory**  
  Contains the `InventoryManager` class that manages collections of animals, employees, enclosures, and food.

- **ZooInventory.Inventory**  
  Contains the `IInventoryManager` interface for inventory management.

- **ZooTests**  
  Contains test code to demonstrate and verify the functionality of the system.

---

## Programming Principles Demonstrated

### DRY (Don't Repeat Yourself)
- **Implementation:**  
  Common behavior for animals is abstracted in the [`IAnimal`](lab-1/lab-1/ZooInventory/Models/IAnimal.cs#L1-L20) interface and the [`Animal`](lab-1/lab-1/ZooInventory/Models/Animal.cs#L1-L30) abstract class. This prevents duplication in classes such as `Mammal` and `Bird`.
- **References:**  
  - [ZooInventory.Models/IAnimal.cs#L1-L20](lab-1/lab-1/ZooInventory/Models/IAnimal.cs#L1-L20)  
  - [Zoo/Models/Animal.cs#L1-L30](lab-1/lab-1/ZooInventory/Models/Animal.cs#L1-L30)

### KISS (Keep It Simple, Stupid)
- **Implementation:**  
  The design is kept simple with clear responsibilities for each class. Each component (animal, employee, enclosure, food, inventory manager) focuses on a single concern. See how the [`Program.cs`](lab-1/lab-1/ZooInventory/Program.cs#L1-L50) file demonstrates straightforward assembly and execution.
- **Reference:**  
  - [Zoo/Program.cs#L1-L50](lab-1/lab-1/ZooInventory/Program.cs#L1-L50)

### SOLID Principles

- **Single Responsibility Principle (SRP):**  
  Every class has one responsibility. For example, [`Employee`](lab-1/lab-1/ZooInventory/Models/Employee.cs#L1-L20) manages employee data, and [`Enclosure`](lab-1/lab-1/ZooInventory/Models/Enclosure.cs#L1-L20) deals solely with enclosure information.
- **References:**  
  - [Zoo/Models/Employee.cs#L1-L20](lab-1/lab-1/ZooInventory/Models/Employee.cs#L1-L20)  
  - [Zoo/Models/Enclosure.cs#L1-L20](lab-1/lab-1/ZooInventory/Models/Enclosure.cs#L1-L20)

- **Open/Closed Principle (OCP):**  
  Classes are designed to be extended without modification. New animal types can be added by extending the [`Animal`](lab-1/lab-1/ZooInventory/Models/Animal.cs#L1-L30) class. For example, [`Mammal`](lab-1/lab-1/ZooInventory/Models/Mammal.cs#L1-L20) and [`Bird`](lab-1/lab-1/ZooInventory/Models/Bird.cs#L1-L20) extend `Animal`.
- **References:**  
  - [Zoo/Models/Animal.cs#L1-L30](lab-1/lab-1/ZooInventory/Models/Animal.cs#L1-L30)  
  - [Zoo/Models/Mammal.cs#L1-L20](lab-1/lab-1/ZooInventory/Models/Mammal.cs#L1-L20)  
  - [Zoo/Models/Bird.cs#L1-L20](lab-1/lab-1/ZooInventory/Models/Bird.cs#L1-L20)

- **Liskov Substitution Principle (LSP):**  
  Derived classes such as `Mammal` and `Bird` can replace their base class (`Animal`) or the `IAnimal` interface without affecting system behavior, as demonstrated in [`ZooTests/Program.cs`](lab-1/lab-1/ZooTests/Program.cs#L10-L20).
- **Reference:**  
  - [ZooTests/Program.cs#L10-L20](lab-1/lab-1/ZooTests/Program.cs#L10-L20)

- **Interface Segregation Principle (ISP):**  
  The [`IAnimal`](lab-1/lab-1/ZooInventory/Models/IAnimal.cs#L1-L20) and [`IInventoryManager`](lab-1/lab-1/ZooInventory/Inventory/IInventoryManager.cs#L1-L20) interfaces are minimal, ensuring that implementing classes only define the necessary methods.
- **References:**  
  - [ZooInventory.Models/IAnimal.cs#L1-L20](lab-1/lab-1/ZooInventory/Models/IAnimal.cs#L1-L20)  
  - [ZooInventory.Inventory/IInventoryManager.cs#L1-L20](lab-1/lab-1/ZooInventory/Inventory/IInventoryManager.cs#L1-L20)

- **Dependency Inversion Principle (DIP):**  
  The system depends on abstractions rather than concrete classes. For example, the [`InventoryManager`](lab-1/lab-1/ZooInventory/Inventory/InventoryManager.cs#L1-L30) works with the `IAnimal` interface rather than specific animal implementations.
- **References:**  
  - [Zoo/Program.cs#L1-L50](lab-1/lab-1/ZooInventory/Program.cs#L1-L50)  
  - [ZooInventory.Inventory/IInventoryManager.cs#L1-L20](lab-1/lab-1/ZooInventory/Inventory/IInventoryManager.cs#L1-L20)

### YAGNI (You Ain't Gonna Need It)
- **Implementation:**  
  The code includes only the functionality required for the assignment. Unnecessary features and overengineering are avoided, keeping the codebase focused and maintainable.
- **Reference:**  
  - Overall design as seen in the folder structure and in files like [Zoo/Models](lab-1/lab-1/ZooInventory/Models) and [Zoo.Inventory/InventoryManager.cs#L1-L30](lab-1/lab-1/ZooInventory/Inventory/InventoryManager.cs#L1-L30)

### Composition Over Inheritance
- **Implementation:**  
  The [`InventoryManager`](lab-1/lab-1/ZooInventory/Inventory/InventoryManager.cs#L1-L30) uses composition by aggregating collections of various objects (animals, employees, enclosures, food) rather than relying solely on inheritance hierarchies.
- **Reference:**  
  - [Zoo.Inventory/InventoryManager.cs#L1-L30](lab-1/lab-1/ZooInventory/Inventory/InventoryManager.cs#L1-L30)

### Program to Interfaces, Not Implementations
- **Implementation:**  
  The system is designed around interfaces (e.g., [`IAnimal`](lab-1/lab-1/ZooInventory/Models/IAnimal.cs#L1-L20) and [`IInventoryManager`](lab-1/lab-1/ZooInventory/Inventory/IInventoryManager.cs#L1-L20)), which allows for greater flexibility and easier testing by decoupling code from concrete implementations.
- **References:**  
  - [ZooInventory.Models/IAnimal.cs#L1-L20](lab-1/lab-1/ZooInventory/Models/IAnimal.cs#L1-L20)  
  - [ZooInventory.Inventory/IInventoryManager.cs#L1-L20](lab-1/lab-1/ZooInventory/Inventory/IInventoryManager.cs#L1-L20)

### Fail Fast
- **Implementation:**  
  Although the current implementation is simple, the structure lays the groundwork for early error detection. For instance, future improvements may include validations in methods of the [`InventoryManager`](lab-1/lab-1/ZooInventory/Inventory/InventoryManager.cs#L1-L30) to immediately report invalid operations.
- **Reference:**  
  - [Zoo.Inventory/InventoryManager.cs#L1-L30](lab-1/lab-1/ZooInventory/Inventory/InventoryManager.cs#L1-L30)

---

## Conclusion

This zoo management system is a practical demonstration of how to apply fundamental programming principles to build a clean, maintainable, and extensible codebase. By adhering to DRY, KISS, SOLID, YAGNI, Composition Over Inheritance, Program to Interfaces not Implementations, and Fail Fast principles, the project is well-organized and easy to extend for future requirements.
