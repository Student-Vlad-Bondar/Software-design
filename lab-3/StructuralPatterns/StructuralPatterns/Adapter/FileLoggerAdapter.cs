using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter
{
    public class FileLoggerAdapter : Logger
    {
        private FileWriter fileWriter;

        public FileLoggerAdapter(string filePath)
        {
            fileWriter = new FileWriter(filePath);
        }

        public override void Log(string message)
        {
            fileWriter.WriteLine("[LOG] " + message);
        }

        public override void Error(string message)
        {
            fileWriter.WriteLine("[ERROR] " + message);
        }

        public override void Warn(string message)
        {
            fileWriter.WriteLine("[WARN] " + message);
        }
    }
}
