using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Prototype
{
    public interface OfficeDocument : ICloneable
    {
        new OfficeDocument Clone(); // 隐藏ICloneable的Clone接口方法定义
        void Display();
    }
}
