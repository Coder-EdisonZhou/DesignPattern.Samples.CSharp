using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Prototype.PrepareAhead
{
    public class ConcretePrototypeB : ICloneable
    {
        public int i = 0;
        public string customAttr = "hello prototype";
        public ConcretePrototype a = new ConcretePrototype();

        public object Clone()
        {
            // 实现深复制-方式1：依次赋值和实例化
            ConcretePrototypeB newObj = new ConcretePrototypeB();
            newObj.a = new ConcretePrototype();
            newObj.a.CustomAttr = this.a.CustomAttr;
            newObj.i = this.i;

            return newObj;
        }

        public new object MemberwiseClone()
        {
            // 实现浅复制
            return base.MemberwiseClone();
        }

        public override string ToString()
        {
            string result = string.Format("I的值为{0},A为{1}", this.i.ToString(), this.a.CustomAttr);
            return result;
        }
    }
}
