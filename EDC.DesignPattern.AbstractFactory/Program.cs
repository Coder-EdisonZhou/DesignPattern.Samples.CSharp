using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.AbstractFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ISkinFactory skinFactory = (ISkinFactory) AppConfigHelper.GetSkinFactoryInstance();
            if (skinFactory == null)
            {
                Console.WriteLine("读取当前选中皮肤类型失败...");
            }

            IButton button = skinFactory.CreateButton();
            ITextField textField = skinFactory.CreateTextField();
            IComboBox comboBox = skinFactory.CreateComboBox();

            button.Display();
            textField.Display();
            comboBox.Display();

            Console.ReadKey();
        }
    }
}
