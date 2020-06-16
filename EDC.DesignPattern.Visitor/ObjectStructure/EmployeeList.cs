using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Visitor
{
    /// <summary>
    /// 对象结构类：EmployeeList
    /// </summary>
    public class EmployeeList
    {
        private IList<IEmployee> empList = new List<IEmployee>();

        public void AddEmployee(IEmployee emp)
        {
            this.empList.Add(emp);
        }

        public void Accept(Department handler)
        {
            foreach (var emp in empList)
            {
                emp.Accept(handler);
            }
        }
    }
}
