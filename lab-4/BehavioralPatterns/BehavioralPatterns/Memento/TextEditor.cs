using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Memento
{
    public class TextEditor
    {
        private TextDocument _document;
        private Stack<DocumentMemento> _history = new Stack<DocumentMemento>();

        public TextEditor(string initialContent)
        {
            _document = new TextDocument(initialContent);
        }

        public void AppendText(string text)
        {
            SaveState(); // Зберегти поточний стан перед модифікацією
            _document.Content += text;
        }

        public void SaveState()
        {
            _history.Push(new DocumentMemento(_document.Content));
        }

        public void Undo()
        {
            if (_history.Count > 0)
            {
                DocumentMemento memento = _history.Pop();
                _document.Content = memento.Content;
            }
            else
            {
                Console.WriteLine("Немає збережених станів для відновлення.");
            }
        }

        public void ShowContent()
        {
            Console.WriteLine("Поточний стан документа:");
            Console.WriteLine(_document.Content);
        }
    }
}
