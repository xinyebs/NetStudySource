using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace MyDelegate
{
    public class SrotList
    {
        public static IComparer<DogEntity> FactorySort(string type)
        {
            IComparer<DogEntity> comparer=null;

            switch (type)
            {
                case "ListGog":  //这个地方也可以用反射
                    comparer = new DogSrot();
                    break;
            }
            return comparer;
        }
    }
}
