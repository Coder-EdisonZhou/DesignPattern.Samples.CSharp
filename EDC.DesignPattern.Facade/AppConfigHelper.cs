using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Facade
{
    public class AppConfigHelper
    {
        public static string GetFacadeName()
        {
            string factoryName = null;
            try
            {
                factoryName = System.Configuration.ConfigurationManager.AppSettings["EncryptFacadeName"];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return factoryName;
        }

        public static object GetFacadeInstance()
        {
            string assemblyName = AppConfigHelper.GetFacadeName();
            Type type = Type.GetType(assemblyName);

            var instance = Activator.CreateInstance(type);
            return instance;
        }
    }
}
