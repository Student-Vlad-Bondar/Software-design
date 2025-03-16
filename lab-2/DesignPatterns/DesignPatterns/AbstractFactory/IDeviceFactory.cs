using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public interface IDeviceFactory
    {
        IDevice CreateLaptop();
        IDevice CreateNetbook();
        IDevice CreateEBook();
        IDevice CreateSmartphone();
    }
}
