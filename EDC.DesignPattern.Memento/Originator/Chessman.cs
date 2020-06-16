using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Memento
{
    /// <summary>
    /// 原发器：Chessman
    /// </summary>
    public class Chessman
    {
        public string Label { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Chessman(string label, int x, int y)
        {
            Label = label;
            X = x;
            Y = y;
        }

        // 保存状态
        public ChessmanMemento Save()
        {
            return new ChessmanMemento(Label, X, Y);
        }

        // 恢复状态
        public void Restore(ChessmanMemento memento)
        {
            Label = memento.Label;
            X = memento.X;
            Y = memento.Y;
        }
    }
}
