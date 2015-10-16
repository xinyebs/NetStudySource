using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace jqueryEasyUI
{
    /// <summary>
    /// BaseHttpHandler 的摘要说明
    /// </summary>
    public class BaseHttpHandler : IHttpHandler, IRequiresSessionState
    {
        public HttpRequest Request;
        public HttpResponse Response;
        public HttpSessionState Session;
        public HttpServerUtility Server;
        public HttpCookie Cookie;
        public virtual void ProcessRequest(HttpContext context)
        {
            Request = context.Request;
            Response = context.Response;
            Session = context.Session;
            Server = context.Server;


        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}