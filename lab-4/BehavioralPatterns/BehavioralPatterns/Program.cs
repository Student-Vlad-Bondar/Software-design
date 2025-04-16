using BehavioralPatterns.ChainOfResponsibility;
using BehavioralPatterns.Mediator;
using BehavioralPatterns.Memento;
using BehavioralPatterns.Observer;
using BehavioralPatterns.Strategy;

namespace BehavioralPatterns
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== Lab4 Demonstration of behavioral patterns ===");
            Console.WriteLine();

            // Завдання 1: Ланцюжок відповідальності
            SupportSystemDemo.Run();

            // Завдання 2: Посередник
            MediatorDemo.Run();

            // Завдання 3: Спостерігач
            ObserverDemo.Run();

            // Завдання 4: Стратегія
            await StrategyDemo.Run();

            // Завдання 5: Мементо
            MementoDemo.Run();

            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}
