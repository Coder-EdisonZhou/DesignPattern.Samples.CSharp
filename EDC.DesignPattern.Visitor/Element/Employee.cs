using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Visitor
{
    /// <summary>
    /// 抽象元素类：Employee
    /// </summary>
    public interface IEmployee
    {
        void Accept(Department handler);
    }

    /// <summary>
    /// 具体元素类：FullTimeEmployee
    /// </summary>
    public class FullTimeEmployee : IEmployee
    {
        public string Name { get; set; }
        public double WeeklyWage { get; set; }
        public int WorkTime { get; set; }

        public FullTimeEmployee(string name, double weeklyWage, int workTime)
        {
            this.Name = name;
            this.WeeklyWage = weeklyWage;
            this.WorkTime = workTime;
        }

        public void Accept(Department handler)
        {
            handler.Visit(this);
        }
    }

    /// <summary>
    /// 具体元素类：PartTimeEmployee
    /// </summary>
    public class PartTimeEmployee : IEmployee
    {
        public string Name { get; set; }
        public double HourWage { get; set; }
        public int WorkTime { get; set; }

        public PartTimeEmployee(string name, double hourWage, int workTime)
        {
            this.Name = name;
            this.HourWage = hourWage;
            this.WorkTime = workTime;
        }

        public void Accept(Department handler)
        {
            handler.Visit(this);
        }
    }
}
