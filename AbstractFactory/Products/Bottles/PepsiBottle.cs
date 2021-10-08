namespace AbstractFactory
{
    public class PepsiBottle : Bottle
    {
        public PepsiBottle(double liters)
        {
            Name = "Pepsi bottle";
            Size = liters;
        }
    }
}
