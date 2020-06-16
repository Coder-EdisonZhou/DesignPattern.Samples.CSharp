using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Flyweight
{
    /// <summary>
    /// 外部状态：棋子坐标
    /// </summary>
    public class Coordinates
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinates()
        {

        }

        public Coordinates(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
