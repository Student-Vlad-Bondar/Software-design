using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class KiaomiFactory : IDeviceFactory
    {
        public IDevice CreateLaptop()
        {
            return new Laptop("Kiaomi Laptop Pro");
        }

        public IDevice CreateNetbook()
        {
            return new Netbook("Kiaomi Netbook Lite");
        }

        public IDevice CreateEBook()
        {
            return new EBook("Kiaomi EBook Plus");
        }

        public IDevice CreateSmartphone()
        {
            return new Smartphone("Kiaomi Smart");
        }
    }
}
