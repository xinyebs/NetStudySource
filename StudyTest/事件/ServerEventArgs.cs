using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 事件
{
   public class ServerEventArgs:System.EventArgs
    {
        public DateTime FireDateTime { get; set; }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public ServerEventArgs() 
        {
            this.FireDateTime = DateTime.Now;
        }

        public ServerEventArgs(DateTime firDateTime)
        {
            this.FireDateTime = firDateTime;
        }
    }
    public delegate void ServerEventHander(object obj ,ServerEventArgs e);
    public class Server
    {
        public event ServerEventHander started;
        public event ServerEventHander stoped;

        public virtual void DoStart(object obj,ServerEventArgs e)
        {
            if (started != null)
            {
                started(obj, e);
            }
        }

        public virtual void DoStop(object obj, ServerEventArgs e)
        {
            if (stoped != null)
            {
                stoped(obj, e);
            }
        }

        public void Start()
        {
            DoStart(this, new ServerEventArgs(DateTime.Now));
        }

        public void Stop()
        {
            DoStop(this,new ServerEventArgs(DateTime.Now));
        }
    }

}
