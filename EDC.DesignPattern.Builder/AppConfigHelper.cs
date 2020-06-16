using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Builder
{
    public class AppConfigHelper
    {
        public static string GetConcreteBuilderName()
        {
            string factoryName = null;
            try
            {
                factoryName = System.Configuration.ConfigurationManager.AppSettings["ConcreteBuilder"];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return factoryName;
        }

        public static object GetConcreteBuilderInstance()
        {
            string assemblyName = AppConfigHelper.GetConcreteBuilderName();
            Type type = Type.GetType(assemblyName);

            var instance = Activator.CreateInstance(type);
            return instance;
        }
    }
}
