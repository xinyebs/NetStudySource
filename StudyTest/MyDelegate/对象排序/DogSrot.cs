using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace MyDelegate
{
    /// <summary>
    /// 狗排序，一个集合，如果都是int ,或者string,直接调用list.sort()，就可以
    /// 实现排序，但是对于实体对象，要实现排序，一种是实现ICoparer<T>接口
    /// 一种是直接委托一个方法。
    /// </summary>
    public class DogSrot:IComparer<DogEntity>
    {
        #region IComparer<DogEntity> 成员

        public int Compare(DogEntity x, DogEntity y)
        {
            return x.Age - y.Age;
        }

        #endregion
    }
}
