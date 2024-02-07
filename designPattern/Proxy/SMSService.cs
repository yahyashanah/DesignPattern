using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.Proxy
{
    public abstract class SMSService
    {
        public abstract string SendSMS(string CustId, string mobile, string sms);
    }
}
