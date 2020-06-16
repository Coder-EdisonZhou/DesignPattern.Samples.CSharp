using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Memento
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //SingleRedoDemo();

            MultiRedoDemo();

            Console.ReadKey();
        }

        #region v1.0 实现单次撤销
        public static void SingleRedoDemo()
        {
            MementoCaretaker mc = new MementoCaretaker();
            Chessman chess = new Chessman("车", 1, 1);
            Display(chess);
            // 保存状态
            mc.Memento = chess.Save();
            chess.Y = 4;
            Display(chess);
            // 保存状态
            mc.Memento = chess.Save();
            Display(chess);
            chess.X = 5;
            Display(chess);

            Console.WriteLine("---------- Sorry，俺悔棋了 ---------");

            // 恢复状态
            chess.Restore(mc.Memento);
            Display(chess);
        }

        public static void Display(Chessman chess)
        {
            Console.WriteLine("棋子 {0} 当前位置为：第 {1} 行 第 {2} 列", chess.Label, chess.X, chess.Y);
        }
        #endregion

        #region v2.0 实现多次撤销
        private static int index = -1;
        private static NewMementoCaretaker mementoCaretaker = new NewMementoCaretaker();

        public static void MultiRedoDemo()
        {
            Chessman chess = new Chessman("车", 1, 1);
            Play(chess);
            chess.Y = 4;
            Play(chess);
            chess.X = 5;
            Play(chess);

            Undo(chess, index);
            Undo(chess, index);
            Redo(chess, index);
            Redo(chess, index);
        }

        // 下棋
        public static void Play(Chessman chess)
        {
            // 保存备忘录
            mementoCaretaker.SetMemento(chess.Save());
            index++;

            Console.WriteLine("棋子 {0} 当前位置为 第 {1} 行 第 {2} 列", chess.Label, chess.X, chess.Y);
        } 

        // 悔棋
        public static void Undo(Chessman chess, int i)
        {
            Console.WriteLine("---------- Sorry，俺悔棋了 ---------");
            index--;
            // 撤销到上一个备忘录
            chess.Restore(mementoCaretaker.GetMemento(i - 1));

            Console.WriteLine("棋子 {0} 当前位置为 第 {1} 行 第 {2} 列", chess.Label, chess.X, chess.Y);
        }

        // 撤销悔棋
        public static void Redo(Chessman chess, int i)
        {
            Console.WriteLine("---------- Sorry，撤销悔棋 ---------");
            index++;
            // 恢复到下一个备忘录
            chess.Restore(mementoCaretaker.GetMemento(i + 1));

            Console.WriteLine("棋子 {0} 当前位置为 第 {1} 行 第 {2} 列", chess.Label, chess.X, chess.Y);
        }
        #endregion
    }
}
