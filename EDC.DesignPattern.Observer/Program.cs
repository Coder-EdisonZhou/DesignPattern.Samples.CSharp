using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Observer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Step1.定义观察者对象
            AllyControlCenter acc = new ConcreteAllyControlCenter("金庸群侠");
            // Step2.定义4个观察者对象
            IObserver playerA = new Player() { Name = "杨过" };
            acc.Join(playerA);
            IObserver playerB = new Player() { Name = "令狐冲" };
            acc.Join(playerB);
            IObserver playerC = new Player() { Name = "张无忌" };
            acc.Join(playerC);
            IObserver playerD = new Player() { Name = "段誉" };
            acc.Join(playerD);
            // Step3.当某盟友遭受攻击
            playerA.BeAttacked(acc);

            Console.ReadKey();
        }
    }
}
