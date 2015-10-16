using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace 延迟等待实现
{
    /// <summary>
    /// Handler1 的摘要说明
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            string response = context.Request["name"];
           
            context.Response.Write("该用户名可以用");
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