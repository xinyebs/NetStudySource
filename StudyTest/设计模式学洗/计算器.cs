using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 设计模式学洗
{
    /// <summary>
    /// 计算器基类
    /// </summary>
    public class 计算器
    {
        private double numbera = 0;
        private double numberb = 0;

        public double NumberA
        {
            get { return this.numbera; }
            set
            {
                this.numbera = value;
            }
        }

        public double NumberB
        {
            get { return this.numberb; }
            set { this.numberb = value; }
        }

        public virtual double GetReult()
        {
            double result = 0;
            return result;
        }
    }
}
