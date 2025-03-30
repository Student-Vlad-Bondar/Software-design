using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Proxy
{
    public class SmartTextChecker
    {
        private SmartTextReader reader = new SmartTextReader();

        public char[][] ReadFile(string filePath)
        {
            Console.WriteLine("Opening file: " + filePath);
            var content = reader.ReadFile(filePath);
            int totalChars = 0;
            foreach (var line in content)
                totalChars += line.Length;
            Console.WriteLine("File read successfully. Lines: " + content.Length + ", Characters: " + totalChars);
            Console.WriteLine("Closing file: " + filePath);
            return content;
        }
    }
}
