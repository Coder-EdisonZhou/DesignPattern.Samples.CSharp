using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPatterm.Decorator
{
    /// <summary>
    /// 构件装饰类：抽象装饰类
    /// </summary>
    public class ComponentDecorator : Component
    {
        private Component component;

        public ComponentDecorator (Component component)
        {
            this.component = component;
        }

        public override void Display()
        {
            component.Display();
        }
    }
}
