using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Bridge
{
    public class WindowsImplementor : ImageImplementor
    {
        public void DoPaint(Matrix m)
        {
            // 调用Windows的绘制函数绘制像素矩阵
            Console.WriteLine("在Windows系统中显示图像");
        }
    }

    public class LinuxImplementor : ImageImplementor
    {
        public void DoPaint(Matrix m)
        {
            // 调用Windows的绘制函数绘制像素矩阵
            Console.WriteLine("在Linux系统中显示图像");
        }
    }

    public class UnixImplementor : ImageImplementor
    {
        public void DoPaint(Matrix m)
        {
            // 调用Windows的绘制函数绘制像素矩阵
            Console.WriteLine("在Unix系统中显示图像");
        }
    }
}
