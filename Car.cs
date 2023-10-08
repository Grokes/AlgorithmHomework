using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmHomework
{
    internal interface IVehicle
    {
        public void Move();
        public void Refill(int oilCount);
    }
    internal class Car : IVehicle
    {
        public int OilCount { get; private set; }

        public Car(int oilCount = 1000)
        {
            OilCount = oilCount;
        }
        public void Move()
        {
            if (OilCount > 100)
            {
                Console.WriteLine("Машина едет");
                OilCount -= 100;
                return;
            }
            Console.WriteLine("Недостаточно топлива");
        }

        public void Refill(int oilCount)
        {
            OilCount += oilCount;
        }
    }
}
