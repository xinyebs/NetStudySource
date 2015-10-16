using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象工厂模式
{
    public class SqlServerFactory:IFactory
    {

        #region IFactory 成员

        public IUser CreaterUser()
        {
            return new SqlServerUser();
        }

        #endregion

        #region IFactory 成员


        public IDepartment CreateDepart()
        {
            throw new NotImplementedException();
        }

        #endregion
    }

    public class AccessFactory : IFactory
    {
        #region IFactory 成员

        public IUser CreaterUser()
        {
            return new AccessUser();
        }

        #endregion

        #region IFactory 成员


        public IDepartment CreateDepart()
        {
            throw new NotImplementedException();
        }

        #endregion
    }

}
