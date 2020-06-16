using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Flyweight
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 获取享元工厂
            IgoChessmanFactory chessFactory = IgoChessmanFactory.GetInstance();
            // 通过享元工厂获取3颗黑子
            IgoChessman blackChess1 = chessFactory.GetIgoChessman("b");
            IgoChessman blackChess2 = chessFactory.GetIgoChessman("b");
            IgoChessman blackChess3 = chessFactory.GetIgoChessman("b");

            Console.WriteLine("判断两颗黑子是否相同：{0}", object.ReferenceEquals(blackChess1, blackChess2));
            // 通过享元工厂获取2颗白子
            IgoChessman whiteChess1 = chessFactory.GetIgoChessman("w");
            IgoChessman whiteChess2 = chessFactory.GetIgoChessman("w");

            Console.WriteLine("判断两颗白子是否相同：{0}", object.ReferenceEquals(whiteChess1, whiteChess2));
            // 显示棋子
            blackChess1.Display(new Coordinates(1,2));
            blackChess2.Display(new Coordinates(3, 4));
            blackChess3.Display(new Coordinates(1, 3));
            whiteChess1.Display(new Coordinates(2, 5));
            whiteChess2.Display(new Coordinates(2, 4));

            Console.ReadKey();
        }
    }
}
