namespace AbstractFactory
{
    public class CocaColaBottle : Bottle
    {
        public CocaColaBottle(double liters)
        {
            Name = "CocaCola bottle";
            Size = liters;
        }
    }
}
