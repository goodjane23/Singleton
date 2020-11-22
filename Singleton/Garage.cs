using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Garage
    {
        private Garage()
        {
            Console.WriteLine("Создание гаража");

        }

        Garage carhouse = new Garage();
    }
}
