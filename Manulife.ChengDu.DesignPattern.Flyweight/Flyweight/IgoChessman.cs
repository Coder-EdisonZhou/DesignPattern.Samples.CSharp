using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manulife.ChengDu.DesignPattern.Flyweight
{
    public abstract class IgoChessman
    {
        public abstract string GetColor();

        public void Display(Coordinates coord)
        {
            Console.WriteLine("棋子颜色：{0}，棋子位置：{1}", GetColor(), coord.X + "," + coord.Y);
        }
    }
}
