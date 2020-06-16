using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Strategy
{
    /// <summary>
    /// 具体策略类：VIP会员票VIPDiscount
    /// </summary>
    public class VIPDiscount : IDiscount
    {
        public double Calculate(double price)
        {
            Console.WriteLine("VIP票：");
            Console.WriteLine("增加积分！");
            return price * 0.5;
        }
    }
}
