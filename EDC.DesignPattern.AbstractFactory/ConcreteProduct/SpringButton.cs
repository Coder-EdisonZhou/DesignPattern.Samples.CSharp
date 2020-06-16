using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.AbstractFactory
{
    public class SpringButton : IButton
    {
        public void Display()
        {
            Console.WriteLine("显示浅绿色按钮...");
        }
    }
}
