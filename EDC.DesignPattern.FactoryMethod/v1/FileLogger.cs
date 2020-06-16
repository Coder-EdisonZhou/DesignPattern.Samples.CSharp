using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.FactoryMethod.v1
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("文件日志记录...");
        }
    }
}
