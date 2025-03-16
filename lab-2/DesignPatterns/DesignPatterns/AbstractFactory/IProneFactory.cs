using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class IProneFactory : IDeviceFactory
    {
        public IDevice CreateLaptop()
        {
            return new Laptop("IProne Laptop X1");
        }

        public IDevice CreateNetbook()
        {
            return new Netbook("IProne Netbook A1");
        }

        public IDevice CreateEBook()
        {
            return new EBook("IProne EBook Reader");
        }

        public IDevice CreateSmartphone()
        {
            return new Smartphone("IProne Phone W");
        }
    }
}
