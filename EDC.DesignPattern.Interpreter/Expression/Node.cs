using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Interpreter
{
    /// <summary>
    /// 抽象表达式：抽象节点类
    /// </summary>
    public abstract class Node
    {
        // 声明一个方法用于解释语句
        public abstract void Interpret(Context context);
        // 声明一个方法用于执行标记对应的命令
        public abstract void Execute();
    }

    /// <summary>
    ///  非终结符表达式：表达式节点类
    /// </summary>
    public class ExpressionNode : Node
    {
        // 用于存储多条命令的集合
        private IList<Node> nodeList = new List<Node>();

        public override void Interpret(Context context)
        {
            // 循环处理Context中的标记
            while (true)
            {
                // 如果已经没有任何标记，则退出解释
                if (context.GetCurrentToken() == null)
                {
                    break;
                }
                // 如果标记为END，则不解释END并结束本次解释过程，可以继续之后的解释
                else if (context.GetCurrentToken().Equals("END", StringComparison.OrdinalIgnoreCase))
                {
                    context.SkipToken("END");
                    break;
                }
                // 如果为其它标记，则解释标记并加入命令集合
                else
                {
                    Node node = new CommandNode();
                    node.Interpret(context);
                    nodeList.Add(node);
                }
            }
        }

        // 循环执行命令集合中的每一条指令
        public override void Execute()
        {
            foreach (var node in nodeList)
            {
                node.Execute();
            }
        }
    }

    /// <summary>
    /// 非终结符表达式：语句命令节点类
    /// </summary>
    public class CommandNode : Node
    {
        private Node node;

        public override void Interpret(Context context)
        {
            // 处理LOOP指令
            if (context.GetCurrentToken().Equals("LOOP", StringComparison.OrdinalIgnoreCase))
            {
                node = new LoopCommand();
                node.Interpret(context);
            }
            // 处理其他指令
            else
            {
                node = new PrimitiveCommand();
                node.Interpret(context);
            }
        }

        public override void Execute()
        {
            node.Execute();
        }
    }

    /// <summary>
    /// 非终结符表达式：循环命令类
    /// </summary>
    public class LoopCommand : Node
    {
        // 循环次数
        private int number;
        // 循环语句中的表达式
        private Node commandNode;

        public override void Interpret(Context context)
        {
            context.SkipToken("LOOP");
            number = context.GetCurrentNumber();
            context.NextToken();
            // 循环语句中的表达式
            commandNode = new ExpressionNode();
            commandNode.Interpret(context);
        }

        public override void Execute()
        {
            for (int i = 0; i < number; i++)
            {
                commandNode.Execute();
            }
        }
    }

    /// <summary>
    /// 终结符表达式：基本命令类
    /// </summary>
    public class PrimitiveCommand : Node
    {
        private string name;
        private string text;

        public override void Interpret(Context context)
        {
            name = context.GetCurrentToken();
            context.SkipToken(name);

            if (!name.Equals("PRINT", StringComparison.OrdinalIgnoreCase) 
                && !name.Equals("BREAK", StringComparison.OrdinalIgnoreCase)
                && !name.Equals("SPACE", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("非法命令！");
            }

            if (name.Equals("PRINT", StringComparison.OrdinalIgnoreCase))
            {
                text = context.GetCurrentToken();
                context.NextToken();
            }
        }

        public override void Execute()
        {
            if (name.Equals("PRINT", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write(text);
            }
            else if (name.Equals("SPACE", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write(" ");
            }
            else if (name.Equals("BREAK", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("\r\n");
            }
        }
    }
}
