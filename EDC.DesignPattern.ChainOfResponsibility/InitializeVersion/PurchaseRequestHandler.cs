using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.ChainOfResponsibility
{
    /// <summary>
    /// 采购单处理类
    /// </summary>
    public class PurchaseRequestHandler
    {
        // 递交采购单给审批者
        public void SendRequestToApprover(PurchaseRequest request)
        {
            if (request.Amount < 5000) // 主任可审批该采购单
            {
                HandleByDirector(request);
            }
            else if(request.Amount < 100000) // 副董事长可审批该采购单
            {
                HandleByVicePresident(request);
            }
            else if (request.Amount < 500000) // 董事长可审批该采购单
            {
                HandleByPresident(request);
            }
            else
            {
                HandleByCongress(request); // 董事会可审批该采购单
            }
        }

        // 主管审批采购单
        private void HandleByDirector(PurchaseRequest request)
        {
            // 代码省略
        }

        // 副董事长审批采购单
        private void HandleByVicePresident(PurchaseRequest request)
        {
            // 代码省略
        }

        // 董事长审批采购单
        private void HandleByPresident(PurchaseRequest request)
        {
            // 代码省略
        }

        // 董事会审批采购单
        private void HandleByCongress(PurchaseRequest request)
        {
            // 代码省略
        }
    }
}
