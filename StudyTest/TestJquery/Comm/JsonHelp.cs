using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace TestJquery.Comm
{
    /// <summary>
    /// json帮助类
    /// </summary>
    public class JsonHelp
    {
        public static string ToResultJson(int isOk,string message)
        {
            StringBuilder jsonBuilder = new StringBuilder();

            jsonBuilder.Append("{");
            jsonBuilder.AppendFormat("\"isOk\":{0},\"message\":\"{1}\"", isOk, stringToJson(message));
            jsonBuilder.Append("}");
            return jsonBuilder.ToString();
        }

        public static string stringToJson(string msg)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < msg.Length; i++)
            {
                char c = msg[i];
                switch (c)
                {
                    case '\'':
                        sb.Append("\\\'");  //对于\'中每一个字符都要转移
                        break;
                    case '"':
                        sb.Append("\\\"");
                        break;
                    case '\b':      //退格
                        sb.Append("\\b");
                        break;
                    case '\f':      //走纸换页
                        sb.Append("\\f");
                        break;
                    case '\n':
                        sb.Append("\\n"); //换行    
                        break;
                    case '\r':      //回车
                        sb.Append("\\r");
                        break;
                    case '\t':      //横向跳格
                        sb.Append("\\t");
                        break;
                    default:
                        sb.Append(c);
                        break;
                }
            }
            sb.Replace("\r\n", "<br/>");
            return sb.ToString();
        }
    }
}