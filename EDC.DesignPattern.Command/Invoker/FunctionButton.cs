using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Command
{
    /// <summary>
    /// 请求发送者：功能键
    /// </summary>
    public class FunctionButton
    {
        // 功能键名称
        public string Name { get; set; }
        // 维持一个抽象命令对象的引用
        private Command command;

        public FunctionButton(string name)
        {
            this.Name = name;
        }

        // 为功能键注入命令
        public void SetCommand(Command command)
        {
            this.command = command;
        }

        // 发送请求的方法
        public void OnClick()
        {
            Console.WriteLine("点击功能键：");
            if (command != null)
            {
                command.Execute();
            }
        }
    }
}
