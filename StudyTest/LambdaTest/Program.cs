using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TradionDelegate();
            Console.ReadKey();
        }

        //static void TradionDelegate()
        //{
        //    List<int> list = new List<int>();
        //    list.AddRange(new int[]{23,34,56,67,7,22});

        //    Predicate<int> callBack = new Predicate<int>(IsEventNumber);
        //    List<int> eventNubers = list.FindAll(callBack);

        //    foreach(int eventNumber in eventNubers)
        //    {
        //        Console.WriteLine(eventNumber);
        //    }
        //}
        //static bool IsEventNumber(int i)
        //{
        //    return (i % 2) == 0;
        //}

        //static void TradionDelegate()
        //{
        //       List<int> list = new List<int>();
        //       list.AddRange(new int[]{23,34,56,67,7,22});

        //      List<int> eventNubers =list.FindAll(delegate(int i){ return (i % 2) == 0; });
        //     foreach(int eventNumber in eventNubers)
        //   {
        //       Console.WriteLine(eventNumber);
        //   }
 
        //}

        static void TradionDelegate()
        {
            List<int> list = new List<int>();
           list.AddRange(new int[]{23,34,56,67,7,22});

           List<int> eventNubers = list.FindAll((i) => {
               Console.WriteLine("value of  i is Current{0}",i);
               return (i % 2) == 0; 
           });
            foreach(int eventNumber in eventNubers)
          {
              Console.WriteLine(eventNumber);
           }
 
        }
    }
}
