using System;
using System.Web;

namespace Utility
{
	/// <summary>
	/// jsUtility ��ժҪ˵����
	/// </summary>
	public class jsUtility
	{
		public jsUtility()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
		}

		public static void OpenWebForm(string url,string name,string future)
		{
			string js=@"<Script language='JavaScript'>
                     window.open('"+url+@"','"+name+@"','"+future+@"')
                  </Script>";
			HttpContext.Current.Response.Write(js);     
		}

		public static void JavaScriptLocationHref(string url)
		{
			string js=@"<Script language='JavaScript'>
                    window.location.replace('{0}');
                  </Script>";
			js=string.Format(js,url);
			HttpContext.Current.Response.Write(js);  
		}

		public static void Alert(object message)
		{
			string js=@"<Script language='JavaScript'>
                    alert('{0}');  
                  </Script>";
			HttpContext.Current.Response.Write(string.Format(js,message.ToString()));
		}

		public static void Confirm(string message)
		{
			string js=@"<script language='javascript'>
				if (confirm({0}))
					{return true;}
					else
					{return false;}
					</script>";
			js = string.Format(js,message);
			HttpContext.Current.Response.Write(js);
		}
	}
}
