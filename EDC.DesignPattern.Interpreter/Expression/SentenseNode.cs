using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Interpreter
{
    /// <summary>
    /// 非终结符表达式：简单句子解释
    /// </summary>
    public class SentenseNode : AbstractNode
    {
        private AbstractNode direction;
        private AbstractNode action;
        private AbstractNode distance;

        public SentenseNode(AbstractNode direction, AbstractNode action, AbstractNode distance)
        {
            this.direction = direction;
            this.action = action;
            this.distance = distance;
        }

        // 简单句子解释操作
        public override string Interpret()
        {
            return direction.Interpret() + action.Interpret() + distance.Interpret();
        }
    }
}
