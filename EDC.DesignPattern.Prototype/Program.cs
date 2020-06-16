using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Prototype
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //V1();

            //V2();

            //V3();

            V4();

            Console.ReadKey();
        }

        public static void PrintWeeklyLog(WeeklyLog log)
        {
            if (log == null)
            {
                return;
            }

            Console.WriteLine("----------- start : M公司个人工作周报 -----------");
            Console.WriteLine("周次：{0}", log.Date);
            Console.WriteLine("员工：{0}", log.Name);
            Console.WriteLine("内容：{0}", log.Content);
            Console.WriteLine("----------- end : M公司个人工作周报 -----------");
        }

        public static void V1()
        {
            // First version
            WeeklyLog log = new WeeklyLog();
            log.Name = "Victor";
            log.Date = "第11周";
            log.Content = "这周工作太忙，每天都在加班！~~~~(>_<)~~~~";
            PrintWeeklyLog(log);
            // Second version based on First version
            WeeklyLog log2 = log.Clone() as WeeklyLog;
            log2.Date = "第12周";
            PrintWeeklyLog(log2);
            // Third version based on First version
            WeeklyLog log3 = log.Clone() as WeeklyLog;
            log3.Date = "第13周";
            PrintWeeklyLog(log3);
        }

        // v2 : 对象深复制，附件浅复制
        public static void V2()
        {
            // First version
            WeeklyLog log = new WeeklyLog();
            log.attachmentList.Add(new Attachment() { Name = "工作总结20170426-20170501_Victor.xlsx" });
            // Second version
            WeeklyLog log2 = log.Clone() as WeeklyLog;
            // Compare 2 object
            Console.WriteLine("周报是否相同：{0}", object.ReferenceEquals(log, log2));
            // Compare 2 attachment
            Console.WriteLine("附件是否相同：{0}", object.ReferenceEquals(log.attachmentList[0], log2.attachmentList[0]));
        }

        // v3 : 整体深复制
        public static void V3()
        {
            // First version
            WeeklyLog log = new WeeklyLog();
            log.attachmentList.Add(new Attachment() { Name = "工作总结20170426-20170501_Victor.xlsx" });
            // Second version
            WeeklyLog log2 = log.Clone() as WeeklyLog;
            // Compare 2 object
            Console.WriteLine("周报是否相同：{0}", object.ReferenceEquals(log, log2));
            // Compare 2 attachment
            Console.WriteLine("附件是否相同：{0}", object.ReferenceEquals(log.attachmentList[0], log2.attachmentList[0]));
        }

        // v4 : 原型管理器
        public static void V4()
        {
            PrototypeManager pm = PrototypeManager.GetInstance();

            OfficeDocument doc1, doc2, doc3, doc4;
            doc1 = pm.GetOfficeDocumentByKey("FAR");
            doc1.Display();
            doc2 = pm.GetOfficeDocumentByKey("FAR");
            doc2.Display();

            Console.WriteLine("是否是同一个FAR：{0}", object.ReferenceEquals(doc1, doc2));

            doc3 = pm.GetOfficeDocumentByKey("SRS");
            doc3.Display();
            doc4 = pm.GetOfficeDocumentByKey("SRS");
            doc4.Display();

            Console.WriteLine("是否是同一个SRS：{0}", object.ReferenceEquals(doc3, doc4));
        }
    }
}
