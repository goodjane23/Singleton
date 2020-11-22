using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage garage1 = Garage.GetInstance();
            Garage garage2 = Garage.GetInstance();

            Car car1 = new Car("Tesla", 200);
            Car car2 = new Car("lada", 20);

            car2.Upgrade(20);
            Console.WriteLine(garage1 == garage2);
            Console.ReadLine();
        }
    }
}
