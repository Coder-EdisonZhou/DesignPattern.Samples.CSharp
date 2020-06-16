using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.TemplateMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Account account = AppConfigHelper.GetAccountInstance() as Account;
            if (account != null)
            {
                account.Handle("张无忌", "123456");
            }

            Console.ReadKey();
        }
    }
}
