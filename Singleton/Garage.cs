using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Garage
    {
        public int sumCar;
        
        static Garage carHouse;
        private Garage()
        {
            Console.WriteLine("Создание гаража");
        }

        public static Garage GetInstance()
        {
            if (carHouse == null)
            {
                carHouse = new Garage();
            }
            return carHouse;
        }

        public void AddCar(Car car)
        {
            Console.WriteLine("мими");
        }
    }
}
