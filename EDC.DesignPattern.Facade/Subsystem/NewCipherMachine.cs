using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Facade
{
    /// <summary>
    /// 新数据加密类：子系统B
    /// </summary>
    public class NewCipherMachine
    {
        public string Encrypt(string plainText)
        {
            Console.WriteLine("数据加密，将明文转换为密文：");
            StringBuilder result = new StringBuilder();
            int key = 10; // 设置密钥，移位数为10

            for (int i = 0; i < plainText.Length; i++)
            {
                char c = plainText[i];
                // 小写字母位移
                if (c >= 'a' && c <= 'z')
                {
                    c += Convert.ToChar(key % 26);
                    if (c > 'z')
                    {
                        c -= Convert.ToChar(26);
                    }

                    if (c < 'a')
                    {
                        c += Convert.ToChar(26);
                    }
                }

                // 大写字母位移
                if (c >= 'A' && c <= 'Z')
                {
                    c += Convert.ToChar(key % 26);
                    if (c > 'Z')
                    {
                        c -= Convert.ToChar(26);
                    }

                    if (c < 'A')
                    {
                        c += Convert.ToChar(26);
                    }
                }
                result.Append(c);
            }

            string encryptedResult = result.ToString();
            Console.WriteLine(encryptedResult);
            return encryptedResult;
        }
    }
}
