using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.ChainOfResponsibility
{
    public class TechnicalEvalHandler : BaseHandler
    {
        public override void HandleRequest(JobApplication request)
        {
            request.Comments.AppendLine("Tech Handler comments");

            if(baseHandler !=  null)
            {
                baseHandler.HandleRequest(request);
            }
            else
            {
                request.Comments.AppendLine("End By Tech Handler");
            }
        }
    }
}
