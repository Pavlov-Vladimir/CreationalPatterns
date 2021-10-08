namespace Builder
{
    public class CocaColaBuilder : AbstractBuilder
    {
        private Product _cocacola = new Product();

        public override void CreateBottle(BottleSize size) => _cocacola.Add(new ColaBottle(size));
        
        public override void CreateCover() => _cocacola.Add(new ColaCover());
        
        public override void CreateLabel() => _cocacola.Add(new ColaLabel());
        
        public override void CreateWater() => _cocacola.Add(new CocaCola());

        public override Product GetProduct() => _cocacola;        
    }
}
