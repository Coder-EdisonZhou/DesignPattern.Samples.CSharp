using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.FactoryMethod.v2
{
    public interface ILoggerFactory
    {
        ILogger CreateLogger();
        ILogger CreateLogger(string args);
        ILogger CreateLogger(object obj);
    }
}
