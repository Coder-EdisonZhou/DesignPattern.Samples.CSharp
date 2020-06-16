using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Proxy
{
    /// <summary>
    /// 抽象主题类：抽象查询接口
    /// </summary>
    public interface ISearcher
    {
        string DoSearch(string userID, string keyword);
    }
}
