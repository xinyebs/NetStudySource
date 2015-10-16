using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象工厂模式.改进抽象工厂模式
{
    /// <summary>
    /// 用简单工厂修改 抽象工厂，免得增加一个数据表的时候
    /// 修改很多类，不符合开放-封闭原则（增加可以，不能修改）
    /// 但还是每次增加的时候，增加switch().
    /// </summary>
    public class DataAccess
    {
        private static string dbClass = "Sqlserver";
        //private static string dbClass = "Access";
        public static IUser CreateUser(string dbClass)
        {

            switch (dbClass)
            {
                case "Sqlserver":
                    return new SqlServerUser();
                case "access":
                    return new AccessUser();
                default:
                    return null;
            }

        }

        public static IDepartment CreateDepart(string dbClass)
        {
            switch (dbClass)
            {
                case "Sqlserver":
                    return new SqlserDepartment();

                case "Access":
                    return new AccessDepartment();
                default:
                    return null;
            }
        }
    }
}
