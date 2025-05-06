using StructuralPatterns.Adapter;
using StructuralPatterns.Bridge;
using StructuralPatterns.Composite;
using StructuralPatterns.Decorator;
using StructuralPatterns.Flyweight;
using StructuralPatterns.Proxy;
using System.Text;
using System.Threading;
using System.Net.Http;
using System.Collections.Generic;
using StructuralPatterns.BehavioralPatterns.Iterator;
using StructuralPatterns.BehavioralPatterns.Command;
using StructuralPatterns.BehavioralPatterns.State;
using StructuralPatterns.BehavioralPatterns.TemplateMethod;

namespace StructuralPatterns
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;


            Console.WriteLine("=== Lab3 Structural Patterns Demonstration ===");
            Console.WriteLine();

            Console.WriteLine("Вибір цілі запуску:");
            Console.WriteLine("0 - Всі завдання 3 лр");
            Console.WriteLine("1 - Тільки 5 завдання");
            int task = Convert.ToInt32(Console.ReadLine());

            switch (task)
            {
                case 0:
                    // Завдання 1: Адаптер
                    Console.WriteLine(">> Adapter Demo:\n");
                    Logger logger = new Logger();
                    logger.Log("This is a log message.");
                    logger.Warn("This is an error message.");
                    logger.Error("This is a warning message.");

                    FileLoggerAdapter fileLogger = new FileLoggerAdapter("log.txt");
                    fileLogger.Log("File log message.");
                    fileLogger.Warn("File error message.");
                    fileLogger.Error("File warning message.");
                    Console.WriteLine();


                    // Завдання 2: Декоратор
                    Console.WriteLine(">> Decorator Demo:\n");
                    // Створюємо героїв
                    Hero warrior = new Warrior("Aragorn");
                    Hero mage = new Mage("Gandalf");
                    Hero paladin = new Paladin("Uther");
                    // Декоруємо героя Warrior
                    warrior = new ArmorDecorator(warrior, "Steel Armor");
                    warrior = new WeaponDecorator(warrior, "Longsword");
                    warrior = new ArtifactDecorator(warrior, "Ring of Strength");
                    // Декоруємо героя Mage
                    mage = new ArtifactDecorator(mage, "Staff of Wisdom");
                    mage = new WeaponDecorator(mage, "Magic Wand");
                    // Декоруємо героя Paladin
                    paladin = new ArmorDecorator(paladin, "Holy Armor");
                    paladin = new ArtifactDecorator(paladin, "Shield of Light");
                    // Виводимо інформацію про кожного героя
                    Console.WriteLine("Warrior Info: " + warrior.GetInfo());
                    Console.WriteLine("Mage Info: " + mage.GetInfo());
                    Console.WriteLine("Paladin Info: " + paladin.GetInfo());
                    Console.WriteLine();


                    // Завдання 3: Міст
                    Console.WriteLine(">> Bridge Demo:\n");
                    IRenderer vector = new VectorRenderer();
                    IRenderer raster = new RasterRenderer();
                    Shape circle = new Circle(vector);
                    Shape square = new Square(raster);
                    Shape triangle = new Triangle(vector);
                    circle.Draw();
                    square.Draw();
                    triangle.Draw();
                    Console.WriteLine();


                    // Завдання 4: Проксі
                    Console.WriteLine(">> Proxy Demo:\n");
                    SmartTextChecker checker = new SmartTextChecker();
                    if (!File.Exists("sample.txt"))
                    {
                        File.WriteAllText("sample.txt", "Hello, world!\nThis is a sample file.\n1234567890\nAnother line of text.");
                    }
                    try
                    {
                        var content = checker.ReadFile("sample.txt");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error reading file: " + ex.Message);
                    }
                    // Приклад роботи SmartTextReaderLocker (заборонено файли, що містять "denied" у назві)
                    if (!File.Exists("notdenied.txt"))
                    {
                        File.WriteAllText("notdenied.txt", "This is a restricted file.");
                    }
                    SmartTextReaderLocker locker = new SmartTextReaderLocker(@"^denied");
                    Console.WriteLine("Attempting to read a notdenied file using locker:");
                    var lockedContent = locker.ReadFile("notdenied.txt");
                    if (!File.Exists("denied_1.txt"))
                    {
                        File.WriteAllText("denied_1.txt", "This is a 1 file.");
                    }
                    Console.WriteLine("Attempting to read a denied file using locker:");
                    var deniedContent = locker.ReadFile("denied_1.txt");
                    Console.WriteLine();


                    // Завдання 5: Компонувальник
                    Console.WriteLine(">> Composite Demo:\n");
                    // Створення простого HTML елементу: <div> з внутрішніми елементами
                    LightElementNode div = new LightElementNode("div");
                    div.CssClasses.Add("container");
                    LightElementNode p = new LightElementNode("p");
                    p.Children.Add(new LightTextNode("This is a paragraph."));
                    div.Children.Add(p);
                    Console.WriteLine("OuterHTML: " + div.OuterHTML());
                    Console.WriteLine("InnerHTML: " + div.InnerHTML());
                    Console.WriteLine();


                    // Завдання 6: Легковаговик
                    Console.WriteLine(">> Flyweight Demo:\n");
                    // Завантаження тексту книги з URL
                    string url = "https://www.gutenberg.org/cache/epub/1513/pg1513.txt";
                    HttpClient client = new HttpClient();
                    string bookText = "";
                    try
                    {
                        bookText = await client.GetStringAsync(url);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error fetching book text: " + ex.Message);
                        return;
                    }
                    int demoLineCount = 20; //0, якщо demo режим вимкнено
                    List<string> lines = new List<string>(bookText.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None));
                    if (demoLineCount > 0 && lines.Count > demoLineCount)
                    {
                        lines = lines.GetRange(0, demoLineCount);
                    }
                    // Перетворюємо текст у HTML-дерево за допомогою HTMLConverter
                    HTMLConverter converter = new HTMLConverter();
                    LightElementNode htmlTree = converter.ConvertTextToHTML(lines);
                    string htmlOutput = htmlTree.OuterHTML();
                    Console.WriteLine("Generated HTML:");
                    Console.WriteLine(htmlOutput);
                    Console.WriteLine();
                    //Підрахунок кількості вузлів у HTML-дереві
                    int nodeCount = CountNodes(htmlTree);
                    Console.WriteLine("Total nodes in HTML tree: " + nodeCount);
                    break;
                case 1:
                    Task5();
                    break;
                default:
                    Console.WriteLine("Такої цілі запуску неіснує!");
                    break;
            }

            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
        static int CountNodes(LightNode node)
        {
            int count = 1;
            if (node is LightElementNode element && element.Children != null)
            {
                foreach (var child in element.Children)
                    count += CountNodes(child);
            }
            return count;
        }
        static void Task5()
        {
            // Завдання 5: Компонувальник
            Console.WriteLine("\n>> Composite Demo:\n");

            LightElementNode div = new LightElementNode("div");
            div.CssClasses.Add("container");

            LightElementNode p = new LightElementNode("p");
            p.Children.Add(new LightTextNode("This is a paragraph."));
            div.Children.Add(p);

            LightElementNode span = new LightElementNode("span");
            span.Children.Add(new LightTextNode("And this is a span."));
            div.Children.Add(span);

            Console.WriteLine("OuterHTML: " + div.OuterHTML());
            Console.WriteLine("InnerHTML: " + div.InnerHTML());
            Console.WriteLine();

            // --- 1) Iterator Demo ---
            Console.WriteLine(">> Iterator Demo:\n");
            var root = div; // використовуємо вже створений div-приклад
            Console.WriteLine("Depth-First Traversal:");
            var dfs = new DepthFirstIterator(root);
            while (dfs.HasNext())
                Console.WriteLine("  " + dfs.Next().OuterHTML());
            Console.WriteLine("Breadth-First Traversal:");
            var bfs = new BreadthFirstIterator(root);
            while (bfs.HasNext())
                Console.WriteLine("  " + bfs.Next().OuterHTML());
            Console.WriteLine();

            // --- 2) Command Demo ---
            Console.WriteLine(">> Command Demo:\n");
            var invoker = new CommandInvoker();
            var newP = new LightElementNode("p");
            var text = new LightTextNode("Командний рядок додано!");
            var addCmd = new AddChildCommand(div, newP);
            var addTextCmd = new AddChildCommand(newP, text);
            invoker.ExecuteCommand(addCmd);
            invoker.ExecuteCommand(addTextCmd);
            Console.WriteLine("After Execute:");
            Console.WriteLine(div.OuterHTML());
            invoker.UndoLast();  // прибираємо текст
            invoker.UndoLast();  // прибираємо <p>
            Console.WriteLine("After Undo:");
            Console.WriteLine(div.OuterHTML());
            invoker.RedoLast();  // повертаємо <p>
            invoker.RedoLast();  // повертаємо текст
            Console.WriteLine("After Redo:");
            Console.WriteLine(div.OuterHTML());
            Console.WriteLine();

            // --- 3) State Demo ---
            Console.WriteLine(">> State Demo:\n");
            var stateDiv = new LightElementNode("span");
            Console.WriteLine($"Initial state: {stateDiv.State.Name}");
            stateDiv.TransitionTo(new InsertedState());
            stateDiv.TransitionTo(new RemovedState());
            Console.WriteLine();

            // --- 4) Template Method Demo ---
            Console.WriteLine(">> Template Method Demo:\n");
            var myDiv = new MyDiv();
            // додаємо класи й стилі, щоб спрацювали відповідні хуки:
            myDiv.CssClasses.Add("highlight");
            myDiv.CssClasses.Add("shadow");
            myDiv.Styles.Add("background-color", "lightblue");
            myDiv.Styles.Add("border", "1px solid black");

            var renderedHtml = myDiv.Render();
            Console.WriteLine("Rendered HTML: " + renderedHtml);
            Console.WriteLine();
        }
    }
}