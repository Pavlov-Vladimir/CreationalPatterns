namespace Builder
{
    public abstract class Cover
    {
        public CoverColor Color { get; protected set; }

        public override string ToString()
        {
            return Color.ToString() + " cover";
        }
    }    
}
