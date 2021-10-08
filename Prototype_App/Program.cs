using System;

namespace Prototype_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Bottle pepsi = new Pepsi();
            BottleSet set = new BottleSet(6);

            set.Pack(pepsi);
            set.Show();

            Console.WriteLine();

            Bottle coca = new Cola();
            BottleSet set2 = new BottleSet(4);

            set2.Pack(coca);
            set2.Show();

            Console.ReadKey();
        }
    }
}
