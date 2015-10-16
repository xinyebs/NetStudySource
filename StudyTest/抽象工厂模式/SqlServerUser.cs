using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象工厂模式
{
    /// <summary>
    /// SqlServer 类，用于访问sql server中的user
    /// </summary>
    public class SqlServerUser : IUser
    {
        #region IUser 成员

        public void Add(User user)
        {
            Console.WriteLine("在sqlserver 插入一条数据");
        }

        public User Getuser(int id)
        {

            Console.WriteLine("获取sqlserver一条数据");
            return null;
        }

        #endregion
    }

    public class AccessUser : IUser
    {
        #region IUser 成员

        public void Add(User user)
        {
            Console.WriteLine("用于access访问add");
        }

        public User Getuser(int id)
        {
            Console.WriteLine("用于access访问Getuser");
            return null;
        }

        #endregion
    }


}
