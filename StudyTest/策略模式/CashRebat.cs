using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式
{
    /// <summary>
    /// 打折促销类
    /// </summary>
    public class CashRebat : CashSupe
    {
        private double Rebat = 1d;

        /// <summary>
        /// 初始化的时候传入 折扣率
        /// </summary>
        /// <param name="rebat"></param>
        public CashRebat(string rebat)
        {
            Rebat = double.Parse(rebat);
        }

        /// <summary>
        /// 实现抽象方法
        /// </summary>
        /// <param name="monye"></param>
        /// <returns></returns>
        public override double acceptCash(double monye)
        {
            return Rebat * monye;
        }

       
    }
}
