using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ///构建Car类型数组
            Car[] myAutos=new Car[5];
            myAutos[0]=new Car("First",34,4);
            myAutos[1] = new Car("Second", 34, 1);
            myAutos[2] = new Car("Third", 34, 25);
            myAutos[3] = new Car("Forth", 34, 54);
            myAutos[4] = new Car("Five", 34, 6);
           
            //Array.Sort(myAutos);

            //foreach (Car t in myAutos)
            //{
            //    Console.WriteLine("CarID:{0},CarName:{1}",t.CarID,t.Name);
            //}
       

            Array.Sort(myAutos,Car.SortByName);
            foreach (Car t in myAutos)
            {
                Console.WriteLine("CarID:{0},CarName:{1}", t.CarID, t.Name);
            }

            Console.ReadKey();

        }
    }
}
