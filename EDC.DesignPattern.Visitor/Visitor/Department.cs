using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Visitor
{
    /// <summary>
    /// 抽象访问者类：Department
    /// </summary>
    public abstract class Department
    {
        // 声明一组重载的访问方法，用于访问不同类型的具体元素
        public abstract void Visit(FullTimeEmployee employee);
        public abstract void Visit(PartTimeEmployee employee);
    }

    /// <summary>
    /// 具体访问者类：FinanceDepartment
    /// </summary>
    public class FinanceDepartment : Department
    {
        // 实现财务部对兼职员工数据的访问
        public override void Visit(PartTimeEmployee employee)
        {
            int workTime = employee.WorkTime;
            double hourWage = employee.HourWage;
            Console.WriteLine("临时工 {0} 实际工资为：{1} 元", employee.Name, workTime * hourWage);
        }

        // 实现财务部对全职员工数据的访问
        public override void Visit(FullTimeEmployee employee)
        {
            int workTime = employee.WorkTime;
            double weekWage = employee.WeeklyWage;

            if (workTime > 40)
            {
                weekWage = weekWage + (workTime - 40) * 50;
            }
            else if (workTime < 40)
            {
                weekWage = weekWage - (40 - workTime) * 80;
                if (weekWage < 0)
                {
                    weekWage = 0;
                }
            }

            Console.WriteLine("正式员工 {0} 实际工资为：{1} 元", employee.Name,  weekWage);
        }
    }

    /// <summary>
    /// 具体访问者类：HRDepartment
    /// </summary>
    public class HRDepartment : Department
    {
        // 实现人力资源部对兼职员工数据的访问
        public override void Visit(PartTimeEmployee employee)
        {
            int workTime = employee.WorkTime;
            Console.WriteLine("临时工 {0} 实际工作时间为：{1} 小时", employee.Name, workTime);
        }

        // 实现人力资源部对全职员工数据的访问
        public override void Visit(FullTimeEmployee employee)
        {
            int workTime = employee.WorkTime;
            Console.WriteLine("正式员工 {0} 实际工作时间为：{1} 小时", employee.Name, workTime);

            if (workTime > 40)
            {
                Console.WriteLine("正式员工 {0} 加班时间为：{1} 小时", employee.Name, workTime - 40);
            }
            else if (workTime < 40)
            {
                Console.WriteLine("正式员工 {0} 请假时间为：{1} 小时", employee.Name, 40 - workTime);
            }
        }
    }
}
