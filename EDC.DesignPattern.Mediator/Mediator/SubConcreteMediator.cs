using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Mediator
{
    public class SubConcreteMediator : ConcreteMediator
    {
        // 增加对Label对象的引用
        public Label label;

        public override void ComponenetChanged(Component c)
        {
            // 单击按钮
            if (c == addButton)
            {
                Console.WriteLine("-- 单击增加按钮 --");
                list.Update();
                cb.Update();
                userNameTextBox.Update();
                // 文本标签更新
                label.Update();
            }
            // 从列表框选择客户
            else if (c == list)
            {
                Console.WriteLine("-- 从列表框选择客户 --");
                cb.Select();
                userNameTextBox.SetText();
            }
            // 从组合框选择客户
            else if (c == cb)
            {
                Console.WriteLine("-- 从组合框选择客户 --");
                cb.Select();
                userNameTextBox.SetText();
            }
        }
    }
}
