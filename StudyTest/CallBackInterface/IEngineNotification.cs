using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CallBackInterface
{
   public interface IEngineNotification
    {
       void AboutToBlow(string msg);
       void Exploded(string msg);
    }
}
