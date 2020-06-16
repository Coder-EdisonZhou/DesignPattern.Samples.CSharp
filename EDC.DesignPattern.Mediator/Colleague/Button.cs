using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Mediator
{
    /// <summary>
    /// 具体同事类：按钮组件
    /// </summary>
    public class Button : Component
    {
        public override void Update()
        {
            // 按钮不产生响应
        }
    }

    /// <summary>
    /// 具体同事类：列表框组件
    /// </summary>
    public class List : Component
    {
        public override void Update()
        {
            Console.WriteLine("列表框增加一项：张无忌");
        }

        public void Select()
        {
            Console.WriteLine("列表框选中项：小龙女");
        }
    }

    /// <summary>
    /// 具体同事类：组合框组件
    /// </summary>
    public class ComboBox : Component
    {
        public override void Update()
        {
            Console.WriteLine("组合框增加一项：张无忌");
        }

        public void Select()
        {
            Console.WriteLine("组合框选中项：小龙女");
        }
    }

    /// <summary>
    /// 具体同事类：文本框组件
    /// </summary>
    public class TextBox : Component
    {
        public override void Update()
        {
            Console.WriteLine("客户信息增加成功后文本框清空");
        }

        public void SetText()
        {
            Console.WriteLine("文本框显示：小龙女");
        }
    }

    /// <summary>
    /// 具体同事类：标签组件
    /// </summary>
    public class Label : Component
    {
        public override void Update()
        {
            Console.WriteLine("文本标签内容改变，客户信息总数量加1");
        }
    }
}
