using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class BalaxyFactory : IDeviceFactory
    {
        public IDevice CreateLaptop()
        {
            return new Laptop("Balaxy UltraBook");
        }

        public IDevice CreateNetbook()
        {
            return new Netbook("Balaxy Netbook");
        }

        public IDevice CreateEBook()
        {
            return new EBook("Balaxy EReader");
        }

        public IDevice CreateSmartphone()
        {
            return new Smartphone("Balaxy Phone");
        }
    }
}
