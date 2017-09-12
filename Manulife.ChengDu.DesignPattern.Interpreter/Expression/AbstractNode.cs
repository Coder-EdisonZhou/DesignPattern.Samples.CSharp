using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manulife.ChengDu.DesignPattern.Interpreter
{
    /// <summary>
    /// 抽象表达式
    /// </summary>
    public abstract class AbstractNode
    {
        public abstract string Interpret();
    }
}
