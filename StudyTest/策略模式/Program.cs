using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace 策略模式
{
    class Program
    {
        static void Main(string[] args)
        {
            CashSupe suber = CashFactroy.CreateCashaccept("打8折");
            suber.acceptCash(300);

            策略模式.修改二策略和简单工厂结合.CashContext content = new 修改二策略和简单工厂结合.CashContext("正常");

            content.GetResult(300);
        }
    }
}
