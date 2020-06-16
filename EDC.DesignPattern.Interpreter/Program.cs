using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Interpreter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //DemoA();

            DemoB();

            Console.ReadKey();
        }

        public static void DemoA()
        {
            string instruction = "up move 5 and down run 10 and left move 5";

            InstructionHandler handler = new InstructionHandler();
            handler.Handle(instruction);

            string interpreted = handler.Output();
            Console.WriteLine("源指令 : {0}", instruction);
            Console.WriteLine("解释后 : {0}", interpreted);
        }

        public static void DemoB()
        {
            string instruction = "LOOP 2 PRINT 杨过 SPACE SPACE PRINT 小龙女 BREAK END PRINT 郭靖 SPACE SPACE PRINT 黄蓉";
            Context context = new Context(instruction);

            Node node = new ExpressionNode();
            node.Interpret(context);

            Console.WriteLine("源指令 : {0}", instruction);
            Console.WriteLine("解释后 : ");

            node.Execute();
        }
    }
}
