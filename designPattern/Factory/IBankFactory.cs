using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.Factory
{
    public interface IBankFactory
    {
        IBank GetBank(string bankCode);
        IPaymentCard GetPaymentCard(string cardNumber); 
    }
}
