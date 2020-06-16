using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Memento
{
    /// <summary>
    /// 负责人：MementoCaretaker
    /// </summary>
    public class MementoCaretaker
    {
        public ChessmanMemento Memento { get; set; }
    }
}
