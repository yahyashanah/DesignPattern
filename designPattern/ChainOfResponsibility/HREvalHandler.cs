using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.ChainOfResponsibility
{
    public class HREvalHandler : BaseHandler
    {
        public override void HandleRequest(JobApplication request)
        {
            #region First Handling Scenario
            request.Comments.AppendLine("HR handler comments");

            if (baseHandler !=  null)
            {
                baseHandler.HandleRequest(request);
            }
            else
            {
               request.Comments.AppendLine("End by HR Handler");
            }
            #endregion
        }
    }
}
