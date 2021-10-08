using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Supervisor supervisor = new Supervisor(new PepsiFactory());

            supervisor.ShowProduct();

            supervisor = new Supervisor(new CocaColaFactory());

            supervisor.ShowProduct();

            Console.ReadKey();
        }
    }
}
