using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.Flyweight
{
    public class DiscountCalcFactory
    {
        public IDiscountCalculator GetDiscountCalc(string calcType)
        {
            IDiscountCalculator calculator = null;
            Dictionary<string,IDiscountCalculator> calclst = new Dictionary<string,IDiscountCalculator>();

            if(calclst.ContainsKey(calcType))
            {
                return calclst[calcType];
            } else
            {
                switch (calcType)
                {
                    case "day":
                        calculator = new DayDiscountCalc();
                        calclst.Add("day", calculator);
                        break;
                    case "item":
                        calculator = new ItemPriceCalc();
                        calclst.Add("item", calculator);
                        break;
                }
                return calculator;
            }
            
        }

    }
}
