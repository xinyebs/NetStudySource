using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// getSession 的摘要说明
/// </summary>
public class getSession
{
    public getSession()
	{
       
	}
    static public void JuageSession()
    {
        HttpCookie cookie =HttpContext.Current.Request.Cookies["userName"];
        if (cookie !=null)
        {
            string name = cookie.Values["name"];
            if (name != "ok")
            {
                Utility.jsUtility.JavaScriptLocationHref("../login.aspx");
                HttpContext.Current.Response.End();
            }
        }
        else
        {
            Utility.jsUtility.JavaScriptLocationHref("../login.aspx");
            HttpContext.Current.Response.End();
        }
    }

    static public void JuageSession(string level)
    {
        string url = "login.aspx";
        if (level.Equals("2"))
            url = "../login.aspx";
        HttpCookie cookie = HttpContext.Current.Request.Cookies["userName"];
        if (cookie != null)
        {
            string name = cookie.Values["name"];
            if (name != "ok")
            {
                Utility.jsUtility.JavaScriptLocationHref(url);
                HttpContext.Current.Response.End();
            }
        }
        else
        {
            Utility.jsUtility.JavaScriptLocationHref(url);
            HttpContext.Current.Response.End();
        }
    }
    static public void DelSession()
    {
        if (HttpContext.Current.Request.Cookies["userName"] != null)
        {
            HttpCookie myCookie = new HttpCookie("userName");
            myCookie.Expires = DateTime.Now.AddDays(-1);
            HttpContext.Current.Response.Cookies.Add(myCookie);
        }
    }
}
