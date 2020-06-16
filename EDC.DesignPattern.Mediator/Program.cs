using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Mediator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Intialize();

            Extended();

            Console.ReadKey();
        }

        public static void Intialize()
        {
            // Step1.定义中介者对象
            ConcreteMediator mediator = new ConcreteMediator();

            // Step2.定义同事对象
            Button addButton = new Button();
            List list = new List();
            ComboBox cb = new ComboBox();
            TextBox userNameTextBox = new TextBox();

            addButton.SetMediator(mediator);
            list.SetMediator(mediator);
            cb.SetMediator(mediator);
            userNameTextBox.SetMediator(mediator);

            mediator.addButton = addButton;
            mediator.list = list;
            mediator.cb = cb;
            mediator.userNameTextBox = userNameTextBox;

            // Step3.点击增加按钮
            addButton.Changed();

            Console.WriteLine("---------------------------------------------");

            // Step4.从列表框选择客户
            list.Changed();
        }

        public static void Extended()
        {
            // Step1.定义中介者对象
            SubConcreteMediator mediator = new SubConcreteMediator();

            // Step2.定义同事对象
            Button addButton = new Button();
            List list = new List();
            ComboBox cb = new ComboBox();
            TextBox userNameTextBox = new TextBox();
            Label label = new Label();

            addButton.SetMediator(mediator);
            list.SetMediator(mediator);
            cb.SetMediator(mediator);
            userNameTextBox.SetMediator(mediator);
            label.SetMediator(mediator);

            mediator.addButton = addButton;
            mediator.list = list;
            mediator.cb = cb;
            mediator.userNameTextBox = userNameTextBox;
            mediator.label = label;

            // Step3.点击增加按钮
            addButton.Changed();

            Console.WriteLine("---------------------------------------------");

            // Step4.从列表框选择客户
            list.Changed();
        }
    }
}
