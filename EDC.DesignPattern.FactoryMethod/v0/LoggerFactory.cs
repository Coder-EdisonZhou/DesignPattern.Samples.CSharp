using EDC.DesignPattern.FactoryMethod.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.FactoryMethod.v0
{
    public class LoggerFactory
    {
        // 简单工厂方法
        public static ILogger CreateLogger(string args)
        {
            if (args.Equals("db", StringComparison.OrdinalIgnoreCase))
            {
                // 连接数据库，代码省略
                // 创建数据库日志记录器对象
                ILogger logger = new DatabaseLogger();
                // 初始化数据库日志记录器，代码省略
                return logger;
            }
            else if(args.Equals("file", StringComparison.OrdinalIgnoreCase))
            {
                // 创建日志文件，代码省略
                // 创建文件日志记录器对象
                ILogger logger = new FileLogger();
                // 初始化文件日志记录器，代码省略
                return logger;
            }
            else
            {
                return null;
            }
        }
    }
}
