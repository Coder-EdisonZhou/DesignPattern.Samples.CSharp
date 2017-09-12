using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manulife.ChengDu.DesignPattern.Command
{
    /// <summary>
    /// 抽象命令类
    /// </summary>
    public abstract class Command
    {
        public abstract void Execute();
    }
}
