using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象工厂模式
{
    /// <summary>
    /// 定义一个访问创建访问User表对象的抽象工程接口
    /// </summary>
    public interface IFactory
    {
        IUser CreaterUser();

        IDepartment CreateDepart();
    }
}
