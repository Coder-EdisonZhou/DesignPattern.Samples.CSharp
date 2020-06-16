using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Command
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Step1.模拟显示功能键设置窗口
            FBSettingWindow window = new FBSettingWindow("功能键设置窗口");

            // Step2.假如目前要设置两个功能键
            FunctionButton buttonA = new FunctionButton("功能键A");
            FunctionButton buttonB = new FunctionButton("功能键B");

            // Step3.读取配置文件和反射生成具体命令对象
            Command commandA = (Command) AppConfigHelper.GetCommandAInstance();
            Command commandB = (Command)AppConfigHelper.GetCommandBInstance();

            // Step4.将命令注入功能键
            buttonA.SetCommand(commandA);
            buttonB.SetCommand(commandB);

            window.AddFunctionButton(buttonA);
            window.AddFunctionButton(buttonB);
            window.Display();

            // Step5.调用功能键的业务方法
            buttonA.OnClick();
            buttonB.OnClick();

            Console.ReadKey();
        }
    }
}
