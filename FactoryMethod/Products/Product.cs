namespace FactoryMethod
{
    public abstract class Product
    {
        public string Name { get; protected set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
