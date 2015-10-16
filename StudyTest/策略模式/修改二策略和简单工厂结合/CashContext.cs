using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式.修改二策略和简单工厂结合
{
    /// <summary>
    /// 
    /// </summary>
    public class CashContext
    {
        CashSupe cs = null;

        public CashContext(string type)
        {
            switch (type)
            {
                case "正常收费":
                    CachNomal cs1 = new CachNomal();
                    cs = cs1;
                    break;
                case "打9折":
                    CashRebat cs2 = new CashRebat("0.9");
                    cs = cs2;
                    break;
                case "满300返100":
                    CashReturn cs3 = new CashReturn("200", "20");
                    cs = cs3;
                    break;
            }
        }

        public double GetResult(double money)
        {
            return cs.acceptCash(money);
        }

    }
}
