using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CallBackInterface
{
   public class CarEventSink:IEngineNotification
    {
       private string name;
       public CarEventSink()
       { }
       public CarEventSink(string sinkName)
       { 
           name = sinkName; 
       }

        #region IEngineNotification 成员

        public void AboutToBlow(string msg)
        {
            Console.WriteLine("{0}Reporting{1}",name,msg);
        }

        public void Exploded(string msg)
        {
            Console.WriteLine("{0}Reporting{1}", name, msg);
        }

        #endregion
    }
}
