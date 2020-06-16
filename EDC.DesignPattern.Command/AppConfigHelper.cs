using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Command
{
    public class AppConfigHelper
    {
        public static string GetCommandAName()
        {
            string factoryName = null;
            try
            {
                factoryName = System.Configuration.ConfigurationManager.AppSettings["HelpCommand"];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return factoryName;
        }

        public static object GetCommandAInstance()
        {
            string assemblyName = AppConfigHelper.GetCommandAName();
            Type type = Type.GetType(assemblyName);

            var instance = Activator.CreateInstance(type);
            return instance;
        }

        public static string GetCommandBName()
        {
            string factoryName = null;
            try
            {
                factoryName = System.Configuration.ConfigurationManager.AppSettings["MinimizeCommand"];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return factoryName;
        }

        public static object GetCommandBInstance()
        {
            string assemblyName = AppConfigHelper.GetCommandBName();
            Type type = Type.GetType(assemblyName);

            var instance = Activator.CreateInstance(type);
            return instance;
        }
    }
}
