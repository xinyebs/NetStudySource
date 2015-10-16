using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式.修改一
{
    /// <summary>
    /// 测试模式 上下文
    /// </summary>
    public class CashContext
    {
        private CashSupe cs = null;
        /// <summary>
        /// 通过构造方法，传入具体的收费策略
        /// 缺点：调用的时候还是在ui层判断用什么策略
        /// </summary>
        /// <param name="cs"></param>
        public CashContext(CashSupe css)
        {
            this.cs = css;
        }

        public double GetResult(double money)
        {
            return cs.acceptCash(money);
        }
    }
}
