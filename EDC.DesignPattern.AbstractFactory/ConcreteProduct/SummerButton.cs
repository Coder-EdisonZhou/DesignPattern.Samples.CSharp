using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.AbstractFactory
{
    public class SummerButton : IButton
    {
        public void Display()
        {
            Console.WriteLine("显示浅蓝色按钮...");
        }
    }
}
