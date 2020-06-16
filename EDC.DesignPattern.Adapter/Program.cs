using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Adapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IScoreOperation operation = (IScoreOperation)AppConfigHelper.GetAdapterInstance();
            if (operation == null)
            {
                return;
            }

            int[] scores = { 84, 76, 50, 69, 90, 91, 88, 96 };
            int[] result;
            int score;

            Console.WriteLine("测试成绩排序结果：");
            result = operation.Sort(scores);
            foreach (int s in result)
            {
                Console.Write("{0},", s.ToString());
            }
            Console.WriteLine();

            Console.WriteLine("查找是否有90分的人：");
            score = operation.Search(scores, 90);
            if (score == -1)
            {
                Console.WriteLine("抱歉，这个真没找到~~~");
            }
            else
            {
                Console.WriteLine("恭喜，的确存在90分选手~~~");
            }

            Console.WriteLine("查找是否有92分的人：");
            score = operation.Search(scores, 92);
            if (score == -1)
            {
                Console.WriteLine("抱歉，这个真没找到~~~");
            }
            else
            {
                Console.WriteLine("恭喜，的确存在92分选手~~~");
            }

            Console.ReadKey();
        }
    }
}
