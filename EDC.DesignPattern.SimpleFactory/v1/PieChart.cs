using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.SimpleFactory.v1
{
    public class PieChart : IChartable
    {
        public PieChart()
        {
            Console.WriteLine("创建饼状图...");
        }

        public void Display()
        {
            Console.WriteLine("显示饼状图...");
        }
    }
}
