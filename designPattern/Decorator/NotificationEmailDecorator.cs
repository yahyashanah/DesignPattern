﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.Decorator
{
    public class NotificationEmailDecorator : AbstractDecorator
    {
        public string SmsSentNotification(string custId,string sms)
        {
            return $"sms {sms}, sent to {custId}, at {DateTime.Now.ToLongDateString()}";
        }

        public override string SendSMS(string custId,string mobile,string sms)
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(base.SendSMS(custId,mobile, sms));

            // decorator method to send email
            result.AppendLine(SmsSentNotification(custId,sms));

            return result.ToString();

        }

    }
}
