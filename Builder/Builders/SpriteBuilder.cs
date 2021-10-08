namespace Builder
{
    public class SpriteBuilder : AbstractBuilder
    {
        private Product _sprite = new Product();

        public override void CreateBottle(BottleSize size) => _sprite.Add(new SpriteBottle(size));
        
        public override void CreateCover() => _sprite.Add(new SpriteCover());
        
        public override void CreateLabel() => _sprite.Add(new SpriteLabel());
        
        public override void CreateWater() => _sprite.Add(new Sprite());

        public override Product GetProduct() => _sprite;        
    }
}
