using designPattern.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.Decorator
{
    public abstract class AbstractDecorator : SMSService
    {
        protected SMSService notificationService;
        public void SetService(SMSService service)
        {
            notificationService = service;
        }
        public override string SendSMS(string CustId, string mobile, string sms)
        {
            if (notificationService != null)
            {
                return notificationService.SendSMS(CustId, mobile, sms);
            }
            else
            {
                return "Notification service not initialized";
            }
        }
    }
}
