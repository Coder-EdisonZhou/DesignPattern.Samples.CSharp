using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manulife.ChengDu.DesignPattern.Prototype.PrepareAhead
{
    public abstract class Prototype
    {
        // 自定义成员
        public string CustomAttr
        {
            get; set;
        }

        public abstract Prototype Clone();
    }
}
