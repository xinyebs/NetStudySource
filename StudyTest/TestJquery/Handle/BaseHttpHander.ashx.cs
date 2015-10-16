using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using TestJquery.Comm;
using TestJquery.Model;

namespace TestJquery.Handle
{
    /// <summary>
    /// BaseHttpHander 的摘要说明
    /// </summary>
    public class BaseHttpHander : IHttpHandler
    {
        public HttpRequest Request;
        public HttpResponse Response;
        public HttpServerUtility Server;
        public HttpSessionState Session;
        public HttpCookie Cookie;
        public SysUser user;
        public virtual void ProcessRequest(HttpContext context)
        {
            Request = context.Request;
            Response = context.Response;
            Server = context.Server;
            Session = context.Session;
        }

        public void WriteSucess()
        {
            WriteMessage(1, "操作成功");
        }
        public void WriteError(string msg)
        {
            WriteMessage(0,msg);
        }
        /// <summary>
        /// 输出 ｛”isOK":1,"message":"操作成功"｝
        /// </summary>
        /// <param name="Status">0失败，1成功</param>
        /// <param name="msg">消息内容</param>
        public void WriteMessage(int Status, string msg)
        {
             Response.Write(JsonHelp.ToResultJson(Status, msg));
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