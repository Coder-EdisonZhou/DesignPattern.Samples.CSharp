using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Strategy
{
    /// <summary>
    /// 具体策略类：儿童票折扣ChildrenDiscount
    /// </summary>
    public class ChildrenDiscount : IDiscount
    {
        public double Calculate(double price)
        {
            Console.WriteLine("儿童票：");
            return price - 10;
        }
    }
}
