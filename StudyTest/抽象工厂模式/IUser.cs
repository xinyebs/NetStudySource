using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象工厂模式
{
    /// <summary>
    /// IUser接口，用于和客户端访问，解除与具体数据库的访问的耦合
    /// </summary>
    public interface IUser
    {
        void Add(User user);
        User Getuser(int id);
    }

    public interface IDepartment
    {
        void Add(DepartMent dep);
        DepartMent GetDepart(int Id);
    }
}
