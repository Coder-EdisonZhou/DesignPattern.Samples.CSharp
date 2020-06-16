using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Bridge
{
    /// <summary>
    /// 抽象操作系统实现类：实现类接口
    /// </summary>
    public interface ImageImplementor
    {
        // 显示像素矩阵
        void DoPaint(Matrix m);
    }

    public class Matrix
    {
        // 此处代码省略
    }
}
