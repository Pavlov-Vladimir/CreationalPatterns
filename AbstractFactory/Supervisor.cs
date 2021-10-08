using System;

namespace AbstractFactory
{
    class Supervisor
    {        
        public Water Water { get ; private set ; }
        public Bottle Bottle { get ; private set ; }

        public Supervisor(AbstractFactory factory)
        {
            Water = factory.CreateWater();
            Bottle = factory.CreateBottle();
        }

        public void ShowProduct()
        {
            Console.WriteLine(Water + " in " + Bottle);
        }

    }
}
