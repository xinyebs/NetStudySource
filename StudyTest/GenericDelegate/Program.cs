using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericDelegate
{
    public delegate void MyGenericDelegate<T>(T arg);
    class Program
    {
        static void Main(string[] args)
        {
            MyGenericDelegate<string> strTarget = new MyGenericDelegate<string>(StringTarget);
            strTarget("Some string Data");

            MyGenericDelegate<int> intTarget = new MyGenericDelegate<int>(IntTarget);

            intTarget(3);

            Console.ReadKey();
            
        }

        static void StringTarget(string arg)
        {
            Console.WriteLine("arg Upper is{0}",arg.ToUpper());
        }

        static void IntTarget(int arg)
        {
            Console.WriteLine("arg is:{0}",++arg);
        }
    }
}
