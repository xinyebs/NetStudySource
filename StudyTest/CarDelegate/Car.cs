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
        public int CarID { get; set; }
        public int CurrSpeed { get; set; }
        public string Name { get; set; }

        public delegate void AboutToBlow(string msg);
        public delegate void Exploded(string msg);

        private AboutToBlow almostDeadList;
        private Exploded explodedList;

        public void OnAboutToBlow(AboutToBlow clienMeth)
        {
            almostDeadList=clienMeth;
        }
        public void OnExploded(Exploded clientMeth)
        {
            explodedList = clientMeth;
        }
        bool carIsDead;

        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                if (explodedList != null)
                {
                    explodedList("Sorry This car is Explord");
                }
            }
 
        }

    }
}
