using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Observer
{
    /// <summary>
    /// 抽象观察类 - IObserver接口
    /// </summary>
    public interface IObserver
    {
        string Name { get; set; }
        void Help();                                                                // 声明支援盟友的方法
        void BeAttacked(AllyControlCenter acc);     // 声明遭受攻击的方法
    }
}
