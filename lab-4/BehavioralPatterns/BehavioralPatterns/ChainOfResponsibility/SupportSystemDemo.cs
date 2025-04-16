using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ChainOfResponsibility
{
    public class SupportSystemDemo
    {
        public static void Run()
        {
            Console.WriteLine(">> Chain of Responsibility Demo:");

            // Створюємо ланцюжок обробників
            ISupportHandler handler1 = new LevelOneHandler();
            ISupportHandler handler2 = new LevelTwoHandler();
            ISupportHandler handler3 = new LevelThreeHandler();
            ISupportHandler handler4 = new LevelFourHandler();

            handler1.SetNext(handler2);
            handler2.SetNext(handler3);
            handler3.SetNext(handler4);

            bool handled = false;
            while (!handled)
            {
                Console.WriteLine("\nВітаємо у системі підтримки. Будь ласка, виберіть тип запиту:");
                Console.WriteLine("1. Загальні питання");
                Console.WriteLine("2. Технічна підтримка");
                Console.WriteLine("3. Фінансові питання");
                Console.WriteLine("4. Критичні звернення");
                Console.Write("Ваш вибір: ");
                string input = Console.ReadLine();

                handled = handler1.HandleRequest(input);

                if (!handled)
                {
                    Console.WriteLine("Некоректний вибір. Будь ласка, оберіть опцію від 1 до 4.");
                }
            }
        }
    }
}
