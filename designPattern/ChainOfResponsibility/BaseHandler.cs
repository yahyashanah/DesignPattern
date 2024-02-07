using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.ChainOfResponsibility
{
    public abstract class BaseHandler
    {
        protected BaseHandler baseHandler;

        public void SetNext(BaseHandler handler)
        {
            baseHandler = handler;
        }
        public abstract void HandleRequest(JobApplication request);
    }
}
