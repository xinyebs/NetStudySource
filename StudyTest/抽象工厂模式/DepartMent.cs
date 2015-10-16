using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象工厂模式
{
    public class DepartMent
    {
        private int Id;
        public int ID
        {
            get { return this.Id; }
            set { this.Id = value; }
        }

        private string depName;
        public string DepName
        {
            get { return this.depName; }
            set { this.depName = value; }
        }
    }
}
