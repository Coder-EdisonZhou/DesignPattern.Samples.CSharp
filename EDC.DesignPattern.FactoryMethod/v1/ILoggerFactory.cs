using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.FactoryMethod.v1
{
    public interface ILoggerFactory
    {
        ILogger CreateLogger();
    }
}
