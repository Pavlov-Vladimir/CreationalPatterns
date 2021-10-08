namespace Builder
{
    public abstract class AbstractBuilder
    {
        public abstract void CreateBottle(BottleSize size);
        public abstract void CreateWater();
        public abstract void CreateCover();
        public abstract void CreateLabel();
        public abstract Product GetProduct();
    }
}
