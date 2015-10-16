using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace 抽象工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {

            IFactory factory = new SqlServerFactory();

            IUser iuser = factory.CreaterUser();

            IDepartment idept= factory.CreateDepart();

            ///第一次改进
            IUser user = 抽象工厂模式.改进抽象工厂模式.DataAccess.CreateUser("Sqlserver");
            IDepartment depart = 抽象工厂模式.改进抽象工厂模式.DataAccess.CreateDepart("Access");


            IUser users = 抽象工厂模式.第二次改进.DataAccess.CreaterUser();
        }
    }
}
