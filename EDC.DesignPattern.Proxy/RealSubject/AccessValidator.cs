using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Proxy
{
    /// <summary>
    /// 业务类：身份验证类
    /// </summary>
    public class AccessValidator
    {
        /// <summary>
        /// 模拟实现登录验证
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public bool Validate(string userID)
        {
            Console.WriteLine("在数据库中验证用户 {0} 是否是合法用户?", userID);
            if (userID.Equals("杨过", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("{0} 登录成功!", userID);
                return true;
            }
            else
            {
                Console.WriteLine("{0} 登录失败!", userID);
                return false;
            }
        }
    }
}
