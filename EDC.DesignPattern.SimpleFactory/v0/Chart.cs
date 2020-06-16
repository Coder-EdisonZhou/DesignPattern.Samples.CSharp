using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDC.DesignPattern.SimpleFactory.v1;

namespace EDC.DesignPattern.SimpleFactory.v0
{
    public class Chart
    {
        private string type; // 图表类型

        public Chart(object[][] data, string type)
        {
            this.type = type;

            if (this.type.Equals("histogram", StringComparison.OrdinalIgnoreCase))
            {
                // 初始化柱状图
            }
            else if (this.type.Equals("pie", StringComparison.OrdinalIgnoreCase))
            {
                // 初始化饼状图
            }
            else if (this.type.Equals("line", StringComparison.OrdinalIgnoreCase))
            {
                // 初始化折线图
            }
        }

        public void Display()
        {
            if (this.type.Equals("histogram", StringComparison.OrdinalIgnoreCase))
            {
                // 显示柱状图
            }
            else if (this.type.Equals("pie", StringComparison.OrdinalIgnoreCase))
            {
                // 显示饼状图
            }
            else if (this.type.Equals("line", StringComparison.OrdinalIgnoreCase))
            {
                // 显示折线图
            }
        }
    }
}
