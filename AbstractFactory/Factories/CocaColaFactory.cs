namespace AbstractFactory
{
    public class CocaColaFactory : AbstractFactory
    {
        public override Bottle CreateBottle()
        {
            return new CocaColaBottle(1.25);
        }

        public override Water CreateWater()
        {
            return new CocaCola();
        }
    }
}
