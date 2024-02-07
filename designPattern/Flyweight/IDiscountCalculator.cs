using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.Flyweight
{
    public interface IDiscountCalculator
    {
        double GetDiscountValue(DateTime currentDate, string itemId = null);
    }
}
