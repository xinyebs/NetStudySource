using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 设计模式学洗
{
    /// <summary>
    /// 加法类，继承自 计算器基类
    /// </summary>
    public class OperationAdd : 计算器
    {
        public override double GetReult()
        {
            //return base.GetReult();

            double result = 0;

            result = NumberA + NumberB;

            return result;
        }
    }

    public class OperationSub : 计算器
    {
        public override double GetReult()
        {
            double result = 0;

            result = NumberA - NumberB;

            return result;
        }
    }


    public class OperationMul : 计算器
    {
        public override double GetReult()
        {
            double result = 0;

            result = NumberA - NumberB;

            return result;
        }
    }


}
