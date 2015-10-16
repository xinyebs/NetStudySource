using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式
{
    /// <summary>
    /// 现金收费抽象类
    /// </summary>
   public abstract class CashSupe
    {
       /// <summary>
       /// 抽象方法 ，子类必须重重写
       /// </summary>
       /// <param name="monye"></param>
       /// <returns></returns>
       public abstract double acceptCash(double monye);

       /// <summary>
       /// 子类都会有 ，但是不能重新，如果是priate,就只能是父类有
       /// </summary>
       /// <param name="moby"></param>
       /// <returns></returns>
       public double Test(double moby)
       {
           return 0;
       }
       /// <summary>
       /// 子类可以重新，也可以不重新
       /// </summary>
       /// <param name="t"></param>
       /// <returns></returns>
       public virtual double Test1(double t)
       {
           return 0;
       }
    }
}
