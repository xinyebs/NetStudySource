using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace stingTojsong测试
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("string is:{0}","''''对不起'，您输入有错'误。");
            Console.WriteLine("Json is:{0}", Tojson("对不起'，您输\"入有错'误。"));

            Console.ReadKey();
        }

        static string Tojson(string msg)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("{");
            sb.AppendFormat("\"message\":\"{0}\"", StringToJson(msg));
            sb.Append("}");
            return sb.ToString();
        }

        static string StringToJson(string msg)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < msg.Length; i++)
            {
                char c = msg[i];

                switch (c)
                {
                    case '\'':
                        sb.Append("\\\'");
                        break;
                    case '\"':
                        sb.Append("\\\"");
                        break;
                    case'\b':
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
