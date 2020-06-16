using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.ChainOfResponsibility
{
    /// <summary>
    /// 审批者类：抽象处理者
    /// </summary>
    public abstract class Approver
    {
        protected Approver successor; // 定义后继对象
        protected string name;  // 审批者姓名

        public Approver(string name)
        {
            this.name = name;
        }

        // 设置后继者
        public void SetSuccessor(Approver successor)
        {
            this.successor = successor;
        }

        // 抽象请求处理方法
        public abstract void ProcessRequest(PurchaseRequest request);
    }

    /// <summary>
    /// 总监：具体处理类
    /// </summary>
    public class Director : Approver
    {
        public Director(string name) : base(name)
        {
        }

        // 具体请求处理方法
        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount < 50000)
            {
                // 处理请求
                Console.WriteLine("主管 {0} 审批采购单：{1}，金额：{2} 元，采购目的：{3}。",
                    this.name, request.Number, request.Amount, request.Purpose);
            }
            else
            {
                // 如果处理不了，转发请求给更高层领导
                this.successor.ProcessRequest(request);
            }
        }
    }

    /// <summary>
    /// 副总裁：具体处理类
    /// </summary>
    public class VicePresident : Approver
    {
        public VicePresident(string name) : base(name)
        {
        }

        // 具体请求处理方法
        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount < 100000)
            {
                // 处理请求
                Console.WriteLine("副总裁 {0} 审批采购单：{1}，金额：{2} 元，采购目的：{3}。",
                    this.name, request.Number, request.Amount, request.Purpose);
            }
            else
            {
                // 如果处理不了，转发请求给更高层领导
                this.successor.ProcessRequest(request);
            }
        }
    }

    /// <summary>
    /// 总裁：具体处理者
    /// </summary>
    public class President : Approver
    {
        public President(string name) : base(name)
        {
        }

        // 具体请求处理方法
        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount < 500000)
            {
                // 处理请求
                Console.WriteLine("总裁 {0} 审批采购单：{1}，金额：{2} 元，采购目的：{3}。",
                    this.name, request.Number, request.Amount, request.Purpose);
            }
            else
            {
                // 如果处理不了，转发请求给更高层领导
                this.successor.ProcessRequest(request);
            }
        }
    }

    /// <summary>
    /// 董事会：具体处理者
    /// </summary>
    public class Congress : Approver
    {
        public Congress(string name) : base(name)
        {
        }

        // 具体请求处理方法
        public override void ProcessRequest(PurchaseRequest request)
        {
            // 处理请求
            Console.WriteLine("董事会 {0} 审批采购单：{1}，金额：{2} 元，采购目的：{3}。",
                this.name, request.Number, request.Amount, request.Purpose);
        }
    }

    /// <summary>
    /// 经理：具体处理者
    /// </summary>
    public class Manager : Approver
    {
        public Manager(string name) : base(name)
        {
        }

        // 具体请求处理方法
        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount < 80000)
            {
                // 处理请求
                Console.WriteLine("经理 {0} 审批采购单：{1}，金额：{2} 元，采购目的：{3}。",
                    this.name, request.Number, request.Amount, request.Purpose);
            }
            else
            {
                this.successor.ProcessRequest(request);
            }
        }
    }
}
