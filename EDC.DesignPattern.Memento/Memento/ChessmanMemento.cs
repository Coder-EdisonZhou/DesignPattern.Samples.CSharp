using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Memento
{
    /// <summary>
    /// 备忘录：ChessmanMemento
    /// </summary>
    public class ChessmanMemento
    {
        public string Label { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public ChessmanMemento(string label, int x, int y)
        {
            Label = label;
            X = x;
            Y = y;
        }
    }
}
