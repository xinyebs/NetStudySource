using System;
using System.Collections.Generic;
using System.Web;

/// <summary>
///RequstString 的摘要说明
/// </summary>
public class RequestString
{
	public RequestString()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}
    public static string Request(string sName)
    {
        return (HttpContext.Current.Request.QueryString[sName] == null ? string.Empty : HttpContext.Current.Request.QueryString[sName].ToString().Trim());
    }
    public static string Action
    {
        get { return Request("Action"); }
    }
    public static string ID
    {
        get { return Request("id"); }
    }
}