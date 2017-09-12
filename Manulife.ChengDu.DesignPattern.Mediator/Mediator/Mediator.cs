using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manulife.ChengDu.DesignPattern.Mediator
{
    /// <summary>
    /// 抽象中介者
    /// </summary>
    public abstract class Mediator
    {
        public abstract void ComponenetChanged(Component c);
    }
}
