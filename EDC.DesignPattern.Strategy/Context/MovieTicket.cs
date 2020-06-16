using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Strategy
{
    /// <summary>
    /// 环境类：电影票MovieTicket
    /// </summary>
    public class MovieTicket
    {
        private double _price;
        private IDiscount _discount;

        public double Price
        {
            get
            {
                return _discount.Calculate(_price);
            }
            set
            {
                _price = value;
            }
        }

        public IDiscount Discount
        {
            set
            {
                _discount = value;
            }
        }
    }
}
