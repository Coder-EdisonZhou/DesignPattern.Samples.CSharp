using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Command
{
    /// <summary>
    /// 具体命令类：帮助命令
    /// </summary>
    public class HelpCommand : Command
    {
        private HelpHandler hander;

        public HelpCommand()
        {
            hander = new HelpHandler();
        }

        // 命令执行方法，将调用请求接受者的业务方法
        public override void Execute()
        {
            if (hander != null)
            {
                hander.Display();
            }
        }
    }
}
