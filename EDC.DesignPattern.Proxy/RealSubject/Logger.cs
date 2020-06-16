using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Proxy
{
    /// <summary>
    /// 业务类：日志记录类
    /// </summary>
    public class Logger
    {
        /// <summary>
        /// 模拟实现日志记录
        /// </summary>
        /// <param name="userID"></param>
        public void Log(string userID)
        {
            Console.WriteLine("更新数据库，用户 {0} 查询次数加1!", userID);
        }
    }
}
