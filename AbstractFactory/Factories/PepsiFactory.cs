namespace AbstractFactory
{
    public class PepsiFactory : AbstractFactory
    {
        public override Bottle CreateBottle()
        {
            return new PepsiBottle(0.33);
        }

        public override Water CreateWater()
        {
            return new Pepsi();
        }
    }
}
