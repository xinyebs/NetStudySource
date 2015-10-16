using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 设计模式学洗
{
    public class 计算器简单工厂
    {
        public static 计算器 CreateOpertion(string operation)
        {
            计算器 op = null;
            switch (operation)
            {
                case "+":
                    op = new OperationAdd();
                    break;

                case "-":
                    op = new OperationSub();
                    break;

                case "*":
                    op = new OperationMul();
                    break;
            }

            return op;
        }
        
    }
}
