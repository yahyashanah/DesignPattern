using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.Flyweight
{
    public class ItemPriceCalc : IDiscountCalculator
    {
        public double GetDiscountValue(DateTime currentDate, string itemId)
        {
            // call database to calc item discount
            return 0.10;
        }
    }
}
