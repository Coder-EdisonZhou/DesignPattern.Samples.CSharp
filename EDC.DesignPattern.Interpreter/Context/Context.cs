using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Interpreter
{
    /// <summary>
    /// 环境类：用于存储和操作需要解释的语句，
    /// 在本实例中每一个需要解释的单词都可以称为一个动作标记（ActionToker）或命令
    /// </summary>
    public class Context
    {
        private int index = -1;
        private string[] tokens;
        private string currentToken;

        public Context(string text)
        {
            text = text.Replace("  ", " ");
            tokens = text.Split(' ');
            NextToken();
        }

        // 获取下一个标记
        public string NextToken()
        {
            if (index < tokens.Length - 1)
            {
                currentToken = tokens[++index];
            }
            else
            {
                currentToken = null;
            }

            return currentToken;
        }

        // 返回当前的标记
        public string GetCurrentToken()
        {
            return currentToken;
        }

        // 跳过一个标记
        public void SkipToken(string token)
        {
            if (!token.Equals(currentToken, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("错误提示：{0} 解释错误！", currentToken);
            }

            NextToken();
        }

        // 如果当前的标记是一个数字，则返回对应的数值
        public int GetCurrentNumber()
        {
            int number = 0;
            try
            {
                // 将字符串转换为整数
                number = Convert.ToInt32(currentToken);
            }
            catch (Exception ex)
            {
                Console.WriteLine("错误提示：{0}", ex.Message);
            }

            return number;
        }
    }
}
