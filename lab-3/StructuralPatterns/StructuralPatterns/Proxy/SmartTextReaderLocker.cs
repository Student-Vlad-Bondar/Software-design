using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StructuralPatterns.Proxy
{
    public class SmartTextReaderLocker
    {
        private SmartTextChecker checker = new SmartTextChecker();
        private Regex deniedPattern;

        public SmartTextReaderLocker(string deniedPattern)
        {
            this.deniedPattern = new Regex(deniedPattern);
        }

        public char[][] ReadFile(string filePath)
        {
            if (deniedPattern.IsMatch(filePath))
            {
                Console.WriteLine("Access denied!");
                return null;
            }
            return checker.ReadFile(filePath);
        }
    }
}
