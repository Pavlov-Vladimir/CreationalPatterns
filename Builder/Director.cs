namespace Builder
{
    public class Director
    {
        AbstractBuilder _builder;

        public Director(AbstractBuilder builder)
        {
            _builder = builder;
        }

        public void Create(BottleSize size)
        {
            _builder.CreateWater();
            _builder.CreateBottle(size);
            _builder.CreateCover();
            _builder.CreateLabel();
        }
    }
}
