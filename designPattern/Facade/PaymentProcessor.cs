using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.Facade
{
    public class PaymentProcessor
    {
        public bool HandlePayment(double amount,string bankInfo)
        {
            return true;
        }
    }
}
