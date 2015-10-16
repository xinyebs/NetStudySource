using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 设计模式学洗
{
    class Program
    {
        static void Main(string[] args)
        {

            计算器 Opertion = 计算器简单工厂.CreateOpertion("+");
            Opertion.NumberA = 12;
            Opertion.NumberB = 22;
            double result = Opertion.GetReult();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
