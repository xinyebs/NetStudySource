using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestJquery.Handle
{
    /// <summary>
    /// LoginOut 的摘要说明
    /// </summary>
    public class LoginOut : BaseHttpHander
    {

        public override void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
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