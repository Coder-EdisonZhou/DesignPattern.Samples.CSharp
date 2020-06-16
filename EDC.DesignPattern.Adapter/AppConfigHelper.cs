using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Adapter
{
    public class AppConfigHelper
    {
        public static string GetAdapterName()
        {
            string factoryName = null;
            try
            {
                factoryName = System.Configuration.ConfigurationManager.AppSettings["AdapterName"];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return factoryName;
        }

        public static object GetAdapterInstance()
        {
            string assemblyName = AppConfigHelper.GetAdapterName();
            Type type = Type.GetType(assemblyName);

            var instance = Activator.CreateInstance(type);
            return instance;
        }
    }
}
