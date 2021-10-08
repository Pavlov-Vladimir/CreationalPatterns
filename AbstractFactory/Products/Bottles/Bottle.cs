namespace AbstractFactory
{
    public abstract class Bottle
    {
        public string Name { get; protected set; }
        public double Size { get; protected set; }

        public override string ToString()
        {
            return "bottle " + Size + "l";
        }
    }
}
