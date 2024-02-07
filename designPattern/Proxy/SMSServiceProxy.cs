using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.Proxy
{
    public class SMSServiceProxy
    {
        //ToDo: Count calls for each customer, if calls > 100 dont send sms
        private SMSService smsService;
        Dictionary<string,int> sentCount = new Dictionary<string,int>();

        public string SerndSMS(string custId, string mobile, string sms)
        {
            if(smsService == null)
            {
                smsService = new ConcreteSMSService();
            }

            // first call
            if (!sentCount.ContainsKey(custId))
            {
                sentCount.Add(custId, 1);
                return smsService.SendSMS(custId, mobile, sms);
            }
            else
            {
                var customer = sentCount.Where(x => x.Key == custId).FirstOrDefault();
                if(customer.Value >= 2)
                { 
                    return "Not sent!";
                }
                else
                { 
                    sentCount[custId] = customer.Value + 1; return smsService.SendSMS(custId, mobile, sms);
                }
            }
            
        }
    }
}
