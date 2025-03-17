# Lab2: Creational Design Patterns

## Objective
The goal of this lab is to learn how to implement various creational design patterns. This project demonstrates the following patterns:
- **Factory Method**
- **Abstract Factory**
- **Singleton**
- **Prototype**
- **Builder**

## Implementation Details

### 1. Factory Method
A system of classes is implemented to create different types of video provider subscriptions.

**Features:**
- **Subscriptions:**
  - **DomesticSubscription** – a basic subscription with a fixed monthly fee, minimum period, and a set of channels.
  - **EducationalSubscription** – designed for educational content.
  - **PremiumSubscription** – an advanced subscription with additional features.
- **Subscription Creators:**
  - **WebSiteSubscriptionCreator** – creates a Premium subscription.
  - **MobileAppSubscriptionCreator** – creates a Domestic subscription.
  - **ManagerCallSubscriptionCreator** – creates an Educational subscription.

**Code References:**
- [ISubscription.cs](DesignPatterns/DesignPatterns/FactoryMethod/ISubscription.cs)
- [PremiumSubscription.cs](DesignPatterns/DesignPatterns/FactoryMethod/PremiumSubscription.cs)

### 2. Abstract Factory
A factory is implemented to produce various devices for different brands.

**Devices:**
- **Laptop**, **Netbook**, **EBook**, **Smartphone** – each implements the `IDevice` interface and provides a `ShowSpecs()` method.

**Factories:**
- **IProneFactory**, **KiaomiFactory**, **BalaxyFactory** – each implements the `IDeviceFactory` interface to create devices.

**Code References:**
- [IDevice.cs](DesignPatterns/DesignPatterns/AbstractFactory/IDevice.cs)
- [IProneFactory.cs](DesignPatterns/DesignPatterns/AbstractFactory/IProneFactory.cs)

### 3. Singleton
The `Authenticator` class ensures that only one instance is created regardless of thread concurrency using a thread-safe `Lazy<T>` implementation.

**Code Reference:**
- [Authenticator.cs](DesignPatterns/DesignPatterns/Singleton/Authenticator.cs)

### 4. Prototype
The `Virus` class demonstrates deep cloning, including recursively cloning all child virus instances.

**Code Reference:**
- [Virus.cs](DesignPatterns/DesignPatterns/Prototype/Virus.cs)

### 5. Builder
The Builder pattern is used to construct game characters with a fluent interface.

**Components:**
- **Interface:** `ICharacterBuilder<TBuilder>` defines methods to set character attributes.
- **Character Class:** Contains properties such as height, physique, hair color, eye color, clothes, inventory, as well as lists of good and evil deeds.
- **Concrete Builders:** `HeroBuilder` and `EnemyBuilder` implement the builder interface to create a hero and an enemy, respectively.
- **Director:** Coordinates the construction process using the builders.

**Code References:**
- [ICharacterBuilder.cs](DesignPatterns/DesignPatterns/Builder/ICharacterBuilder.cs)
- [HeroBuilder.cs](DesignPatterns/DesignPatterns/Builder/HeroBuilder.cs)

## Demonstration
The main class, `Program.cs`, demonstrates the usage of all patterns:
- **Factory Method Demo:** Creating subscriptions via different channels.
- **Abstract Factory Demo:** Producing devices via different factories.
- **Singleton Demo:** Authenticating with a single instance.
- **Prototype Demo:** Cloning a family of viruses with deep cloning.
- **Builder Demo:** Building characters (hero and enemy) using builders.

## UML Diagrams
All UML diagrams were created using [diagrams.net](https://app.diagrams.net/). The exported diagram files are included in the repository:
- **Factory Method Diagram:** [FactoryMethod.drawio.png](DesignPatterns/DesignPatterns/FactoryMethod.drawio.png)
- **Abstract Factory Diagram:** [AbstractFactory.drawio.png](DesignPatterns/DesignPatterns/AbstractFactory.drawio.png)
- **Builder Diagram:** [Builder.drawio.png](DesignPatterns/DesignPatterns/Builder.drawio.png)

## Conclusion
This project demonstrates practical applications of core creational design patterns. Their implementation helps break the system into modular, reusable components and adheres to key programming principles, ensuring maintainability and scalability of the code.
