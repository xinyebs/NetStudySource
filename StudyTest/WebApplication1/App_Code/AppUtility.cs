using System;
using System.Collections.Generic;
using System.Web;

/// <summary>
///AppUtility 的摘要说明
/// </summary>
public class AppUtility
{
	public AppUtility()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}
    public static string Application(string sName)
    {
        return (HttpContext.Current.Application[sName] == null ? string.Empty : HttpContext.Current.Application[sName].ToString().Trim());
    }
    public static string SiteName
    {
        get { return Application("SiteName"); }
    }
    public static string CopyRight
    {
        get { return Application("CopyRight"); }
    }
    public static string SiteUrl
    {
        get { return Application("SiteUrl"); }
    }
}