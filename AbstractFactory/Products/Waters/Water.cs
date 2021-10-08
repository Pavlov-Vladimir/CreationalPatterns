namespace AbstractFactory
{
    public abstract class Water
    {
        public string Name { get; protected set; }

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
