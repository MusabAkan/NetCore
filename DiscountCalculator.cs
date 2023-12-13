using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore
{
    public static class DiscountCalculator
    {
        public static decimal Calculate(Customer customer)
        {
            return customer.IsActive ? 0.1M : 0;
        }
    }
}
