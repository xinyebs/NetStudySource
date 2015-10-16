using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace CallBackInterface
{
    public class Car
    {
        public Car(string name, int CurrSed, int CarId)
        {
            this.CarID = CarId;
            this.Name = name;
            this.CurrSpeed = CurrSed;
        }
        int maxSpeed = 2;
        public int CarID { get; set; }
        public int CurrSpeed { get; set; }
        public string Name { get; set; }

        ArrayList ClientSinks = new ArrayList();

        public void Advise(IEngineNotification sink)
        {
            ClientSinks.Add(sink);
        }

        public void Unadvise(IEngineNotification sink)
        {
            ClientSinks.Remove(sink);
        }

        bool carIsDead;

        public void Accelerate(int Delta)
        {
            if (carIsDead)
            {
                foreach (IEngineNotification sink in ClientSinks)
                {
                    sink.Exploded("Sorrory,this car is dead...");
                }
            }
            else
            {
                CurrSpeed += Delta;

                if((CurrSpeed-maxSpeed)==10)
                {
                   foreach (IEngineNotification sink in ClientSinks)
                  {
                    sink.Exploded("Ganna blow...");
                  }
                }
                   
            }
        }
    }
}
