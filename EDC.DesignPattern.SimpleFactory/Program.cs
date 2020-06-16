using EDC.DesignPattern.SimpleFactory.v1;
using EDC.DesignPattern.SimpleFactory.v2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.SimpleFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // v1.0
            //ClientV1();

            //Console.WriteLine();

            // v2.0
            ClientV2();

            Console.ReadKey();
        }

        public static void ClientV1()
        {
            IChartable chart = ChartFactory.GetChart("histogram");
            if (chart != null)
            {
                chart.Display();
            }

            chart = ChartFactory.GetChart("pie");
            if (chart != null)
            {
                chart.Display();
            }
        }

        public static void ClientV2()
        {
            string type = AppConfigHelper.GetChartType();
            if (string.IsNullOrEmpty(type))
            {
                return;
            }

            IChartable chart = ChartFactory.GetChart(type);
            if (chart != null)
            {
                chart.Display();
            }
        }
    }
}
