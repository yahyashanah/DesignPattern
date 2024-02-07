using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.Proxy
{
    public class ConcreteSMSService : SMSService
    {
        public override string SendSMS(string CustId, string mobile, string sms)
        {
            return $"CustomerId {CustId}, sms sent to {mobile}";
        }
    }
}
