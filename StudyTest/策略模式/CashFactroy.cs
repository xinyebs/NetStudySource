using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式
{
    /// <summary>
    /// 现金收费简单工厂
    /// </summary>
   public class CashFactroy
    {
       public static CashSupe CreateCashaccept(string type)
       {
           CashSupe cs = null;
           switch (type)
           {
               case "正常收费":
                   cs= new CachNomal();
                   break;
               case "满300返100":
                   cs = new CashReturn("300", "100");
                   break;

               case "打8折":
                   CashRebat rebat = new CashRebat("0.8");
                   cs = rebat;
                   break;
           }
           return cs;
       }

    }
}
