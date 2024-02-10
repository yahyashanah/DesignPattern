using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.ChainOfResponsibility
{
    public class HREvalHandler : BaseHandler
    {
        void ToNext(JobApplication request)
        {
            if (baseHandler != null)
            {
                baseHandler.HandleRequest(request);
            }
            else
            {
                request.Comments.AppendLine("End by HR Handler");
            }
        }
        public override void HandleRequest(JobApplication request)
        {
            #region Handling 1
            //request.Comments.AppendLine("HR handler comments");

            //if (baseHandler !=  null)
            //{
            //    baseHandler.HandleRequest(request);
            //}
            //else
            //{
            //   request.Comments.AppendLine("End by HR Handler");
            //}
            #endregion

            #region Handling 2
            //if (request.JobCode == "456")
            //{
            //    request.Comments.AppendLine("HR handler comments");
            //}
            //else if(baseHandler != null)
            //{
            //   baseHandler.HandleRequest(request);
            //}
            //else
            //{
            //   request.Comments.AppendLine("End by HR Handler");
            //}
            #endregion

            if (request.JobCode == "456")
            {
                request.Comments.AppendLine("HR handler comments");
                ToNext(request);
            }
            else
            {
                ToNext(request);
            }
           
        }
    }
}
