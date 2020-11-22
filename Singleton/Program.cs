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
            Car car1 = new Car("Tesla", 200);
            Car car2 = new Car("lada", 20);
            Console.ReadLine();
        }
    }
}
