using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Interpreter
{
    /// <summary>
    /// 终结符表达式：方向解释
    /// </summary>
    public class DirectionNode : AbstractNode
    {
        private string direction;

        public DirectionNode(string direction)
        {
            this.direction = direction;
        }

        // 方向表达式的解释操作
        public override string Interpret()
        {
            string result = string.Empty;
            switch (direction.ToLower())
            {
                case "up":
                    result = "向上";
                    break;
                case "down":
                    result = "向下";
                    break;
                case "left":
                    result = "向左";
                    break;
                case "right":
                    result = "向右";
                    break;
                default:
                    result = "无效命令";
                    break;
            }

            return result;
        }
    }
}
