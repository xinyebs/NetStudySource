using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象工厂模式
{
    public class AccessDepartment : IDepartment
    {
        #region IDepartment 成员

        public void Add(DepartMent dep)
        {
            throw new NotImplementedException();
        }

        public DepartMent GetDepart(int Id)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
