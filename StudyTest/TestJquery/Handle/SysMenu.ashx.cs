using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace TestJquery.Handle
{
    /// <summary>
    /// SysMenu 的摘要说明
    /// </summary>
    public class SysMenu :BaseHttpHander
    {
        public override void ProcessRequest(HttpContext context)
        {
            base.ProcessRequest(context);

            string methd = Request["Method"] ?? "";
            if (!string.IsNullOrWhiteSpace(methd))
            {
                GetMenuByUserID();
            }

        }

        public void GetMenuByUserID()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{menus:");
            sb.Append("[");
            sb.Append("{");
            sb.AppendFormat("\"menuid: \"{0}\"","1");
            sb.AppendFormat("\", menuname:\"{0}\"", "车组信息");
            sb.AppendFormat("\",url:\"{0}\"","CarTableList.aspx");
            sb.Append("}");
            sb.Append("]");
            sb.Append("}");

            Response.Write(sb.ToString());
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