using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Singleton
{
    /// <summary>
    /// 假装自己是一个负载均衡器
    /// </summary>
    public class LoadBalancer
    {
        // 私有静态变量，存储唯一实例
        //private static LoadBalancer instance = null;
        //private static readonly LoadBalancer instance = new LoadBalancer();
        //private static readonly object syncLocker = new object();
        // 服务器集合
        private IList<CustomServer> serverList = null;

        // 私有构造函数
        private LoadBalancer()
        {
            serverList = new List<CustomServer>();
        }

        // 公共静态成员方法，返回唯一实例
        public static LoadBalancer GetLoadBalancer()
        {
            // 第一重判断
            //if (instance == null)
            //{
            //    // 锁定代码块
            //    lock (syncLocker)
            //    {
            //        // 第二重判断
            //        if (instance == null)
            //        {
            //            instance = new LoadBalancer();
            //        }
            //    }
            //}
            //return instance;
            return Nested.instance;
        }

        // 使用内部类+静态构造函数实现延迟初始化
        class Nested
        {
            static Nested() { }
            internal static readonly LoadBalancer instance = new LoadBalancer();
        }

        // 添加一台Server
        public void AddServer(CustomServer server)
        {
            serverList.Add(server);
        }

        // 移除一台Server
        public void RemoveServer(string serverName)
        {
            foreach (var server in serverList)
            {
                if (server.Name.Equals(serverName))
                {
                    serverList.Remove(server);
                    break;
                }
            }
        }

        // 获得一台Server - 使用随机数获取
        private Random rand = new Random();
        public CustomServer GetServer()
        {
            int index = rand.Next(serverList.Count);

            return serverList[index];
        }
    }
}
