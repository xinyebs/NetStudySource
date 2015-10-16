using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;

namespace TestJquery.Handle
{
    /// <summary>
    /// Login 登录
    /// </summary>
    public class Login : BaseHttpHander
    {

        public override void ProcessRequest(HttpContext context)
        {
            base.ProcessRequest(context);
            string method = Request["Method"] ?? "";
            if (!string.IsNullOrEmpty(method))
            {
                LoginMethod();
            }
        }

        private void LoginMethod()
        {
            Thread.Sleep(5000);
            Response.Buffer = true;
            Response.ExpiresAbsolute = DateTime.Now.AddDays(-1);
            Response.AddHeader("pragma", "no-cache");
            Response.AddHeader("cache-control", "");
            Response.CacheControl = "no-cache";
            Response.ContentType = "text/plain";

            try
            {
                string userName = Request["username"];
                string password = Request["password"];

                if (!string.IsNullOrWhiteSpace(userName) || !string.IsNullOrWhiteSpace(password))
                {
                    WriteSucess();
                }
                else
                {
                    WriteError("登录失败");
                }
            }
            catch (Exception ex)
            {
                WriteError(ex.ToString());
            }
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