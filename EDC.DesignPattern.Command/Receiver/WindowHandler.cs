using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Command
{
    /// <summary>
    /// 请求接受者：帮助文档处理类
    /// </summary>
    public class WindowHandler
    {
        public void Minimize()
        {
            Console.WriteLine("正在最小化窗口至托盘...");
        }
    }
}
