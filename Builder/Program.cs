using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractBuilder builder = new CocaColaBuilder();
            Director director = new Director(builder);

            director.Create(BottleSize.Large);

            Product product = builder.GetProduct();

            product.Show();

            builder = new SpriteBuilder();
            director = new Director(builder);
            director.Create(BottleSize.Small);

            product = builder.GetProduct();
            product.Show();

            Console.ReadKey();
        }
    }
}
