using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.SimpleFactory.v2
{
    public class AppConfigHelper
    {
        public static string GetChartType()
        {
            string chartType = null;
            try
            {
                chartType = System.Configuration.ConfigurationManager.AppSettings["charttype"];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return chartType;
        }
    }
}
