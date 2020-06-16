using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Prototype.PrepareAhead
{
    public class ConcretePrototype : Prototype
    {
        // 克隆方法
        public override Prototype Clone()
        {
            // 创建新对象
            Prototype prototype = new ConcretePrototype();
            prototype.CustomAttr = this.CustomAttr;

            return prototype;
        }
    }
}
