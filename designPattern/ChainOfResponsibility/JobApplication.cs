using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.ChainOfResponsibility
{
    public class JobApplication
    {
        public string ApplicationName { get; set; }
        public string JobTitle { get; set; }
        public string JobCode { get; set; }
        public StringBuilder Comments {  get; set; }
        public string ShowComments()
        {
            return Comments.ToString();
        }
    }
}
