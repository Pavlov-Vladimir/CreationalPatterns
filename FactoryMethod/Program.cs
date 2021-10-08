using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main()
        {
            IFactory factory = new BottleFactory();
            Product bottle = factory.Create();

            factory = new WaterFactory();
            Product water = factory.Create();

            Console.WriteLine(water + " in " + bottle);

            Console.ReadKey();
        }
    }
}
