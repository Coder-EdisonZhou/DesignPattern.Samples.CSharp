using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Interpreter
{
    /// <summary>
    /// 工具类：指令处理
    /// </summary>
    public class InstructionHandler
    {
        private AbstractNode node;

        public void Handle(string instruction)
        {
            AbstractNode left = null, right = null;
            AbstractNode direction = null, action = null, distance = null;
            // 声明一个栈用以存储抽象语法树
            Stack<AbstractNode> nodeStack = new Stack<AbstractNode>();
            // 以空格分隔指令字符串
            string[] words = instruction.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                // 这里采用栈的方式来处理指令，如果遇到"and"，
                // 则将其后的3个单词作为3个终结符表达式连成一个简单句子
                // SentenseNode作为"and"的右表达式，而将从栈顶弹出的表达式作为"and"的左表达式，
                // 最后将"and"表达式压栈
                if (words[i].Equals("and", StringComparison.OrdinalIgnoreCase))
                {
                    // 弹出栈顶表达式作为左表达式
                    left = nodeStack.Pop();
                    // 构造右表达式
                    string word1 = words[++i];
                    direction = new DirectionNode(word1);
                    string word2 = words[++i];
                    action = new ActionNode(word2);
                    string word3 = words[++i];
                    distance = new DistanceNode(word3);
                    
                    right = new SentenseNode(direction, action, distance);
                    // 新表达式压栈
                    AndNode newNode = new AndNode(left, right);
                    nodeStack.Push(newNode);
                }
                // 如果是从头开始进行解释，则将前3个单词组成一个简单句子SentenseNode并将该句子压栈
                else
                {
                    // 构造左表达式
                    string word1 = words[i];
                    direction = new DirectionNode(word1);
                    string word2 = words[++i];
                    action = new ActionNode(word2);
                    string word3 = words[++i];
                    distance = new DistanceNode(word3);

                    left = new SentenseNode(direction, action, distance);

                    nodeStack.Push(left);
                }
            }
            // 全部表达式出栈
            this.node = nodeStack.Pop();
        }

        public string Output()
        {
            // 解释表达式
            string result = node.Interpret();
            return result;
        }
    }
}
