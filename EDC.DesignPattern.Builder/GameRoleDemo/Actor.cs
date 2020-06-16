using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Builder
{
    /// <summary>
    /// Actor 角色类 ： 复杂产品，这里只列出部分成员变量
    /// </summary>
    public class Actor
    {
        // 角色类型
        public string Type { get; set; }
        // 性别
        public string Sex { get; set; }
        // 脸型
        public string Face { get; set; }
        // 服装
        public string Costume { get; set; }
        // 发型
        public string HairStyle { get; set; }
    }
}
