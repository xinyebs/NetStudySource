using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象工厂模式
{
   public class User
    {
        private int Id;
        public int ID
        {

            get { return this.Id; }
            set { this.Id = value; }
        }

        private string userName;
        public string UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }

    }
}
