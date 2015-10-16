using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace 抽象工厂模式.第二次改进
{
    /// <summary>
    /// 通过反射来获取，需要的db，可从配置文件获取，同时每次不是
    /// new SqlServerUser();而是动态获取，程序从编译转到运行时
    /// </summary>
    public class DataAccess
    {
        //程序集名称
        private static readonly string AccemblyName = "抽象工厂模式";

        private static readonly string db = "SqlServer";

        public static IUser CreaterUser()
        {
            string className = AccemblyName + "." + db + "User";

            return (IUser)Assembly.Load(AccemblyName).CreateInstance(className);
        }
     
    }
}
