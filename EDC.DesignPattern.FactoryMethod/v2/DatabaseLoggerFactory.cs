using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.FactoryMethod.v2
{
    public class DatabaseLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            // 使用默认方式连接数据库，代码省略
            ILogger logger = new DatabaseLogger();
            // 初始化数据库日志记录器，代码省略
            return logger;
        }

        public ILogger CreateLogger(string args)
        {
            // 使用参数args作为连接字符串来连接数据库，代码省略
            ILogger logger = new DatabaseLogger();
            // 初始化数据库日志记录器，代码省略
            return logger;
        }

        public ILogger CreateLogger(object obj)
        {
            // 使用封装在参数obj中的连接字符串来连接数据库，代码省略
            ILogger logger = new DatabaseLogger();
            // 使用封装在参数obj中的数据来初始化数据库日志记录器，代码省略
            return logger;
        }
    }
}
