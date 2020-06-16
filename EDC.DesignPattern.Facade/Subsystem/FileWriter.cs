using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Facade
{
    /// <summary>
    /// 文件保存类：子系统C
    /// </summary>
    public class FileWriter
    {
        public void Write(string encryptedStr, string fileNameDes)
        {
            Console.WriteLine("保存密文，写入文件：");
            byte[] myByte = System.Text.Encoding.UTF8.GetBytes(encryptedStr);
            using (System.IO.FileStream fsWrite = new System.IO.FileStream(fileNameDes, System.IO.FileMode.Append))
            {
                fsWrite.Write(myByte, 0, myByte.Length);
            };

            Console.WriteLine("写入文件成功：100%");
        }
    }
}
