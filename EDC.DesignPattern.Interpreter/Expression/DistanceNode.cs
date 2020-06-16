using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Interpreter
{
    /// <summary>
    /// 终结符表达式：距离解释
    /// </summary>
    public class DistanceNode : AbstractNode
    {
        private string distance;

        public DistanceNode(string distance)
        {
            this.distance = distance;
        }

        // 距离表达式的解释操作
        public override string Interpret()
        {
            return this.distance;
        }
    }
}
