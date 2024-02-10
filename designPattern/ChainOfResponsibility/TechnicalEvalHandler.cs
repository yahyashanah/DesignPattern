using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.ChainOfResponsibility
{
    public class TechnicalEvalHandler : BaseHandler
    {
        void ToNext(JobApplication request)
        {
          if (baseHandler != null)
          {
            baseHandler.HandleRequest(request);
          }
          else
          {
            request.Comments.AppendLine("End By Tech Handler");
          }
            
        }
        public override void HandleRequest(JobApplication request)
        {
            #region Handling 1
            //request.Comments.AppendLine("Tech Handler comments");

            //if(baseHandler !=  null)
            //{
            //    baseHandler.HandleRequest(request);
            //}
            //else
            //{
            //    request.Comments.AppendLine("End By Tech Handler");
            //}
            #endregion

            #region Handling 2

            //if (request.JobCode == "123")
            //{
            //    request.Comments.AppendLine("Tech Comments");
            //}
            //else
            //{
            //    if(baseHandler != null)
            //    {
            //        baseHandler.HandleRequest(request);
            //    }
            //    else
            //    {
            //        request.Comments.AppendLine("End By Tech Handler");
            //    }
            //}
            #endregion

            if (request.JobCode == "123")
            {
                request.Comments.AppendLine("Tech Comments");
                ToNext(request);
            }
            else
            {
                ToNext(request);
            }
        }
    }
}
