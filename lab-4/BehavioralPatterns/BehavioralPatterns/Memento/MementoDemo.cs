using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Memento
{
    public class MementoDemo
    {
        public static void Run()
        {
            Console.WriteLine("\n>> Memento Demo:\n");

            TextEditor editor = new TextEditor("Початковий текст.\n");
            editor.ShowContent();

            editor.AppendText("Додано перший рядок.\n");
            editor.ShowContent();

            editor.AppendText("Додано другий рядок.\n");
            editor.ShowContent();

            Console.WriteLine("Відміна останніх змін...");
            editor.Undo();
            editor.ShowContent();

            Console.WriteLine("Відміна ще одного кроку...");
            editor.Undo();
            editor.ShowContent();
        }
    }
}
