using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace StudyTest
{
    public class Car:IComparable
    {
        public Car(string name,int CurrSed,int CarId)
        {
            this.CarID = CarId;                   //构造函数
            this.Name = name;
            this.CurrSpeed = CurrSed; 
        }
        public int CarID { get; set; }
        public int CurrSpeed { get; set; }
        public string Name { get; set; }
        #region IComparable 成员  实现IComparable接口

        int IComparable.CompareTo(object obj) //IComparable.CompareTo 如果该类实现多个接口，防止重名
        {
            Car temp = (Car)obj;
            //if (this.CarID > temp.CarID)
            //    return 1;
            //if (this.CarID < temp.CarID)
            //    return -1;
            //else
            //    return 0;

           //因为该字段是Int类型，该类型实现了该接口，所以上面的方法可以简写为下面的
            return this.CarID.CompareTo(temp.CarID);
        }
        /// <summary>
        /// 静态属性辅助调用
        /// </summary>
         public static IComparer SortByName
         {
             get { return (IComparer)new PetNameComparer(); }
         }
             
        #endregion
    }

    public class PetNameComparer : IComparer
    {

        #region IComparer 成员

       public  int Compare(object x, object y)
        {
            Car t1 = (Car)x;
            Car t2 = (Car)y;

            return string.Compare(t1.Name, t2.Name);
        }

        #endregion
    }
}
