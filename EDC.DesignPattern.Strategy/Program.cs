using EDC.DesignPattern.Strategy.IntializeVersion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Strategy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //InitializeTest();

            MovieTicket mt = new MovieTicket();
            double originalPrice = 60.0;
            double currentPrice = originalPrice;

            mt.Price = originalPrice;
            Console.WriteLine("原始票价：{0}", originalPrice);
            Console.WriteLine("----------------------------------------");

            IDiscount discount = AppConfigHelper.GetStrategyInstance() as IDiscount;
            if (discount != null)
            {
                mt.Discount = discount;
                currentPrice = mt.Price;
            }
            Console.WriteLine("折后票价：{0}", currentPrice);

            Console.ReadKey();
        }

        public static void InitializeTest()
        {
            //MovieTicket mt = new MovieTicket();
            //double originalPrice = 60.0;    // 原始票价
            //double currentPrice;                 // 折后票价
            //mt.Price = originalPrice;

            //Console.WriteLine("原始票价：{0}", originalPrice);
            //Console.WriteLine("----------------------------------------");

            //mt.Type = "student";
            //currentPrice = mt.Calculate();
            //Console.WriteLine("折后票价：{0}", currentPrice);
            //Console.WriteLine("----------------------------------------");

            //mt.Type = "children";
            //currentPrice = mt.Calculate();
            //Console.WriteLine("折后票价：{0}", currentPrice);
            //Console.WriteLine("----------------------------------------");
        }
    }
}
