using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoldMannger
{
    public class EFMannger
    {
        public static void Factory()
        {
            using (FoldDBEntities fs = new FoldDBEntities())
            {
                
            }
        }
    }
}