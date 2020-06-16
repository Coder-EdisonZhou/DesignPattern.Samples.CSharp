using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Iterator
{
    /// <summary>
    /// 抽象迭代器：AbstractIterator
    /// </summary>
    public interface AbstractIterator
    {
        void Next();                                  // 移动至下一个元素
        bool IsLast();                               // 判断是否为最后一个元素
        void Previous();                        // 移动至上一个元素
        bool IsFirst();                             // 判断是否为第一个元素
        object GetNextItem();           // 获取下一个元素
        object GetPreviousItem();   // 获取上一个元素
    }
}
