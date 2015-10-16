using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式
{
    /// <summary>
    /// 正常收费子类
    /// </summary>
    public class CachNomal : CashSupe
    {
        public override double acceptCash(double money)
        {
            return money;
        }
    }
}
