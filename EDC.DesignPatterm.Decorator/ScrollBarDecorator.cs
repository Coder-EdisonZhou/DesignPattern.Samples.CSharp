using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPatterm.Decorator
{
    /// <summary>
    /// 滚动条装饰类：具体装饰类
    /// </summary>
    public class ScrollBarDecorator : ComponentDecorator
    {
        public ScrollBarDecorator(Component component) : base(component)
        {

        }

        public override void Display()
        {
            this.SetScrollBar();
            base.Display();
        }

        public void SetScrollBar()
        {
            Console.WriteLine("为构件增加滚动条!");
        }
    }

    /// <summary>
    /// 黑色边框装饰类：具体装饰类
    /// </summary>
    public class BlackBorderDecorator : ComponentDecorator
    {
        public BlackBorderDecorator(Component component) : base(component)
        {

        }

        public override void Display()
        {
            this.SetScrollBar();
            base.Display();
        }

        public void SetScrollBar()
        {
            Console.WriteLine("为构件增加黑色边框!");
        }
    }
}
