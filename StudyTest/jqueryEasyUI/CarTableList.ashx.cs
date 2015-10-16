using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Reflection;
using System.Data;
using WheelsetSystem.Common;

namespace jqueryEasyUI
{
    /// <summary>
    /// CarTableList 的摘要说明
    /// </summary>
    public class CarTableList : BaseHttpHandler
    {

        public override void ProcessRequest(HttpContext context)
        {
            base.ProcessRequest(context);
            string method = Request["Method"] ?? "";
            if (!string.IsNullOrEmpty(method))
            {
                foreach (MethodInfo mi in this.GetType().GetMethods())
                {
                    if (mi.Name.ToLower() == method.ToLower())
                    {
                        mi.Invoke(this, null);
                        break;
                    }
                }
            }

        }

        public void GetList()
        {
            int PageSize = 10;
            int PageIndex = 1;
            string Order = "desc";
            string Sort = "trainsetNo";
            PageSize = string.IsNullOrEmpty(Request["rows"]) ? PageSize : int.Parse(Request["rows"]);
            PageIndex = string.IsNullOrEmpty(Request["page"]) ? PageIndex : int.Parse(Request["page"]);
            Sort = string.IsNullOrEmpty(Request["sort"]) ? Sort : Request["sort"];
            Order = string.IsNullOrEmpty(Request["order"]) ? Order : Request["order"];

            StringBuilder sqlWhere = new StringBuilder(1024);
            sqlWhere.Append(" 1=1 ");
            string gearBox_No = Request["trainsetNo"];
            if (!string.IsNullOrEmpty(gearBox_No))
            {
                sqlWhere.AppendFormat(" and trainsetNo='{0}'", gearBox_No);
            }

            DataSet ds = DBUtility.GetRecordByPage.GetList("view_CarOnlyRow", PageSize, PageIndex, Sort, Order, "1=1");
            Response.Write(JsonHelper.Dataset2Json(ds));
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