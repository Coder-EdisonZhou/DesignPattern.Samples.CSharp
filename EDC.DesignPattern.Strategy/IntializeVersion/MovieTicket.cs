using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Strategy.IntializeVersion
{
    public class MovieTicket
    {
        public double Price
        {
            get;
            set;
        }
        public string Type { private get; set; }

        // 计算打折之后的票价
        public double Calculate()
        {
            // 学生票折后票价计算
            if (this.Type.Equals("student", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("学生票：");
                return this.Price * 0.8;
            }
            // 儿童票折后票价计算
            else if (this.Type.Equals("children", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("儿童票：");
                return this.Price - 10;
            }
            // VIP票折后票价计算
            else if (this.Type.Equals("vip", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("VIP票：");
                Console.WriteLine("增加积分！");
                return this.Price * 0.5;
            }
            else
            {
                return this.Price; // 不满足任何条件则原价出售
            }
        }
    }
}
