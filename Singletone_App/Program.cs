using System;

namespace Singletone_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Singletone singletone1 = Singletone.GetInstance();

            Singletone singletone2 = Singletone.GetInstance();

            Console.WriteLine(singletone1.Number);
            Console.WriteLine(singletone2.Number);

            Console.ReadKey();
        }
    }
}
