using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Command
{
    /// <summary>
    /// 功能键设置窗口类
    /// </summary>
    public class FBSettingWindow
    {
        // 窗口标题
        public string Title { get; set; }
        // 所有功能键集合
        private IList<FunctionButton> functionButtonList = new List<FunctionButton>();

        public FBSettingWindow(string title)
        {
            this.Title = title;
        }

        public void AddFunctionButton(FunctionButton fb)
        {
            functionButtonList.Add(fb);
        }

        public void RemoveFunctionButton(FunctionButton fb)
        {
            functionButtonList.Remove(fb);
        }

        // 显示窗口及功能键
        public void Display()
        {
            Console.WriteLine("显示窗口：{0}", this.Title);
            Console.WriteLine("显示功能键：");

            foreach (var fb in functionButtonList)
            {
                Console.WriteLine(fb.Name);
            }

            Console.WriteLine("------------------------------------------");
        }
    }
}
