using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式
{
    /// <summary>
    /// 返利子类  
    /// </summary>
  public  class CashReturn:CashSupe
    {
      private double condition = 0d; //返利条件，如满300返利

      private double moneyretun = 0d; //返利多少，

      public CashReturn(string conditon, string returu)
      {
          condition=double.Parse(conditon);
          moneyretun=double.Parse(returu);
      }

        public override double acceptCash(double monye)
        {
            double result = 0d;

            if (monye > condition)
                result = monye - moneyretun;

            return result;
        }
    }
}
