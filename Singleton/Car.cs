using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Car
    {
        string name;
        int maxSpeed;
        public Car(string name, int maxSpeed)
        {
            name = this.name;
            maxSpeed = this.maxSpeed;
        }

        public void Upgrade(int maxSpeed)
        {
            maxSpeed += 50;
        }
    }
}
