using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Bridge
{
    public class JPGImage : Image
    {
        public override void ParstFile(string fileName)
        {
            // 模拟解析JPG文件并获得一个像素矩阵对象m
            Matrix m = new Matrix();
            imageImpl.DoPaint(m);
            Console.WriteLine("{0} : 格式为JPG", fileName);
        }
    }

    public class BMPImage : Image
    {
        public override void ParstFile(string fileName)
        {
            // 模拟解析BMP文件并获得一个像素矩阵对象m
            Matrix m = new Matrix();
            imageImpl.DoPaint(m);
            Console.WriteLine("{0} : 格式为BMP", fileName);
        }
    }

    public class GIFImage : Image
    {
        public override void ParstFile(string fileName)
        {
            // 模拟解析BMP文件并获得一个像素矩阵对象m
            Matrix m = new Matrix();
            imageImpl.DoPaint(m);
            Console.WriteLine("{0} : 格式为GIF", fileName);
        }
    }
}
