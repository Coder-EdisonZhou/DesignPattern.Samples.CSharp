using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Visitor.InitializeVersion
{
    public  class EmployeeList
    {
        // 员工集合
        private IList<Employee> empList = new List<Employee>();

        // 增加员工
        public void AddEmployee(Employee emp)
        {
            this.empList.Add(emp);
        }

        // 处理员工数据
        public void Handle(string deptName)
        {
            if (deptName.Equals("财务部"))
            {
                foreach (var emp in empList)
                {
                    if (emp.GetType().Equals("FullTimeEmployee"))
                    {
                        Console.WriteLine("财务部处理全职员工数据！");
                    }
                    else
                    {
                        Console.WriteLine("财务部处理兼职员工数据！");
                    }
                }
            }
            else if (deptName.Equals("人力资源部"))
            {
                foreach (var emp in empList)
                {
                    if (emp.GetType().Equals("FullTimeEmployee"))
                    {
                        Console.WriteLine("人力资源部处理全职员工数据！");
                    }
                    else
                    {
                        Console.WriteLine("人力资源部处理兼职员工数据！");
                    }
                }
            }
        }
    }
}
