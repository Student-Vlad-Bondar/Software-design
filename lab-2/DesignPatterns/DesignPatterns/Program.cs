using System;
using System.IO;
using System.Reflection.Emit;
using System.Text;
using DesignPatterns.FactoryMethod;
using DesignPatterns.AbstractFactory;
using DesignPatterns.Singleton;
using DesignPatterns.Prototype;
using DesignPatterns.Builder;

namespace Lab2DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("=== Factory Method Demo ===");
            ISubscriptionCreator websiteCreator = new WebSiteSubscriptionCreator();
            ISubscription websiteSubscription = websiteCreator.CreateSubscription();
            websiteSubscription.ShowDetails();

            ISubscriptionCreator mobileCreator = new MobileAppSubscriptionCreator();
            ISubscription mobileSubscription = mobileCreator.CreateSubscription();
            mobileSubscription.ShowDetails();

            ISubscriptionCreator managerCreator = new ManagerCallSubscriptionCreator();
            ISubscription managerSubscription = managerCreator.CreateSubscription();
            managerSubscription.ShowDetails();

            Console.WriteLine("\n=== Abstract Factory Demo ===");
            IDeviceFactory factory1 = new IProneFactory();
            var laptop = factory1.CreateLaptop();
            laptop.ShowSpecs();
            var smartphone = factory1.CreateSmartphone();
            smartphone.ShowSpecs();
            IDeviceFactory factory2 = new KiaomiFactory();
            var book = factory2.CreateEBook();
            book.ShowSpecs();

            Console.WriteLine("\n=== Singleton Demo ===");
            Authenticator.Instance.Authenticate("User1", "password123");

            Console.WriteLine("\n=== Prototype Demo ===");
            var grandParent = new Virus("VP-Grand", "StrainA", 5, 0.2);
            var parent1 = new Virus("VP-Parent1", "StrainB", 3, 0.1);
            var parent2 = new Virus("VP-Parent2", "StrainB", 3, 0.1);
            var child1 = new Virus("VP-Child1", "StrainC", 1, 0.05);
            var child2 = new Virus("VP-Child2", "StrainC", 1, 0.05);

            parent1.Children.Add(child1);
            parent2.Children.Add(child2);
            grandParent.Children.Add(parent1);
            grandParent.Children.Add(parent2);

            Console.WriteLine("Original Virus:");
            grandParent.Display();
            Virus clonedVirus = (Virus)grandParent.Clone();
            Console.WriteLine("\nCloned Virus:");
            clonedVirus.Display();

            Console.WriteLine("\n=== Builder Demo ===");
            Director director = new Director();

            HeroBuilder heroBuilder = new HeroBuilder();
            Character hero = director.BuildHero(heroBuilder);
            Console.WriteLine("  Hero:");
            Console.WriteLine(hero);

            EnemyBuilder enemyBuilder = new EnemyBuilder();
            Character enemy = director.BuildEnemy(enemyBuilder);
            Console.WriteLine("\n  Enemy:");
            Console.WriteLine(enemy);

            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}